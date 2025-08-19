using Microsoft.AspNetCore.Mvc;
using Orion.Admin.Areas.API;
using Orion.Admin.Models;
using Orion.DataAccess.AllFeatures;
using Orion.DataAccess.Entities;

namespace Orion.Admin.Controllers
{
    public class SearchController : Controller
    {
        private readonly IBusinessOwnerService _service;
        private readonly IFeatureManager _featureManager;

        public SearchController(IBusinessOwnerService service, 
            IFeatureManager featureManager)
        {
            _service = service ?? throw new ArgumentNullException("service", "service is null.");
            _featureManager = featureManager ?? throw new ArgumentNullException("featureManager", "featureManager is null.");
        }

        // GET: Search
        public ActionResult Index()
        {
            if (_featureManager.Search == false)
            {
                return NotFound();
            }

            var model = new SearchViewModel();

            if (_featureManager.SearchByBirthBusinessProvince)
            {
                return View("IndexProvinceSearch", model);
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(SearchViewModel model)
        {
            if (model == null)
            {
                throw new InvalidOperationException("Argument cannot be null.");
            }

            if (_featureManager.Search == false)
            {
                return NotFound();
            }

            // var results = _Service.Search(model.FirstName, model.LastName);

            IList<BusinessOwner>? results = null;

            if (_featureManager.SearchByBirthBusinessProvince)
            {
                results = _service.Search(
                    model.FirstName, model.LastName,
                    model.BirthProvince, model.BusinessProvince);
            }
            else
            {
                results = _service.Search(
                    model.FirstName, model.LastName);
            }

            var modelToReturn = new SearchViewModel();

            modelToReturn.FirstName = model.FirstName;
            modelToReturn.LastName = model.LastName;

            if (results != null)
            {
                Adapt(results, modelToReturn.Results);
            }

            if (_featureManager.SearchByBirthBusinessProvince)
            {
                return View("IndexProvinceSearch", modelToReturn);
            }

            return View(modelToReturn);
        }

        private void Adapt(IList<BusinessOwner> fromValues, List<SearchResultRow> toValues)
        {
            if (fromValues == null)
                throw new ArgumentNullException("fromValues", "fromValues is null.");
            if (toValues == null)
                throw new ArgumentNullException("toValues", "toValues is null.");

            var adapter = new BusinessOwnerToSearchResultRowAdapter();

            SearchResultRow toValue;

            foreach (var fromValue in fromValues)
            {
                toValue = new SearchResultRow();

                adapter.Adapt(fromValue, toValue);

                toValues.Add(toValue);
            }
        }
    }
}