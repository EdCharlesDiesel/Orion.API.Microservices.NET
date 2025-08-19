using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Orion.Admin.Areas.API;
using Orion.DataAccess.Entities;
using Orion.Domain.Constants;
using Orion.Domain.Utility;

namespace Orion.Admin.Controllers
{

    // [Authorize(Roles = SecurityConstants.RoleName_Admin)]
    public class BusinessOwnerController : Controller
    {
        private const int IdForCreateNewBusinessowner = 0;
        private IBusinessOwnerService _businessOwnerService;
        private IValidatorStrategy<BusinessOwner> _validator;
        private readonly ITestDataUtility _testDataUtility;

        public BusinessOwnerController(IBusinessOwnerService businessOwnerService,
            IValidatorStrategy<BusinessOwner> validator,
            ITestDataUtility testDataUtility
            )
        {
            if (businessOwnerService == null)
                throw new ArgumentNullException("service", "service is null.");

            if (validator == null)
            {
                throw new ArgumentNullException(nameof(validator), "Argument cannot be null.");
            }

            _validator = validator;
            _businessOwnerService = businessOwnerService;
            _testDataUtility = testDataUtility;
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            var businessOwners = _businessOwnerService.GetBusinessOwners();

            return View(businessOwners);
        }

        [AllowAnonymous]
        [Route("/[controller]/[action]/{id}")]
        [Route("/businessOwner/{id}.aspx")]
        public ActionResult Details(int? id)
        {
            if (id == null || id.HasValue == false)
            {
                return new BadRequestResult();
            }

            var businessOwner = _businessOwnerService.GetBusinessOwnerById(id.Value);

            if (businessOwner == null)
            {
                return NotFound();
            }

            return View(businessOwner);
        }

        [Route("/businessOwner/{last:alpha}/{first:alpha}")]
        public ActionResult Details(string last, string first)
        {
            if (String.IsNullOrWhiteSpace(last) ||
                String.IsNullOrWhiteSpace(first))
            {
                return new BadRequestResult();
            }

            var businessOwner = _businessOwnerService.Search(
                first, last).FirstOrDefault();

            if (businessOwner == null)
            {
                return NotFound();
            }

            return View("Details", businessOwner);
        }

        public ActionResult Create()
        {
            return RedirectToAction("Edit", new { id = IdForCreateNewBusinessowner });
        }

        // [Authorize(Roles = SecurityConstants.RoleName_Admin)]
        [Authorize(Policy = SecurityConstants.PolicyNameEditBusinessOwner)]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }

            BusinessOwner businessOwner;

            if (id.Value == IdForCreateNewBusinessowner)
            {
                // create new
                businessOwner = new BusinessOwner();
                businessOwner.AddTerm(BusinessOwnerConstants.BusinessOwner,
                    default(DateTime),
                    default(DateTime), 0);
            }
            else
            {
                businessOwner = _businessOwnerService.GetBusinessOwnerById(id.Value);
            }

            if (businessOwner == null)
            {
                return NotFound();
            }

            return View(businessOwner);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // [Authorize(Roles = SecurityConstants.RoleName_Admin)]
        [Authorize(Policy = SecurityConstants.PolicyNameEditBusinessOwner)]
        public ActionResult Edit(BusinessOwner businessOwner)
        {
            if (_validator.IsValid(businessOwner))
            {
                bool isCreateNew = false;

                if (businessOwner.Id == IdForCreateNewBusinessowner)
                {
                    isCreateNew = true;
                }
                else
                {
                    BusinessOwner toValue =
                        _businessOwnerService.GetBusinessOwnerById(businessOwner.Id);

                    if (toValue == null)
                    {
                        return new BadRequestObjectResult(
                            String.Format("Unknown businessOwner id '{0}'.", businessOwner.Id));
                    }
                }

                _businessOwnerService.Save(businessOwner);

                if (isCreateNew)
                {
                    RedirectToAction("Edit", new { id = businessOwner.Id });
                }
                else
                {
                    return RedirectToAction("Edit");
                }
            }

            return View(businessOwner);
        }

        //[AllowAnonymous]
        public async Task<ActionResult> ResetDatabase()
        {
            await _testDataUtility.CreateBusinessOwnerTestData();

            return RedirectToAction("Index");
        }

        //[AllowAnonymous]
        public ActionResult VerifyDatabaseIsPopulated()
        {
            _testDataUtility.VerifyDatabaseIsPopulated();

            return RedirectToAction("Index");
        }
    }
}