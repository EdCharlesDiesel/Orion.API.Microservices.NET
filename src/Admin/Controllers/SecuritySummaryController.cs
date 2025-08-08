using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Orion.Admin.Controllers
{
    public class SecuritySummaryController : Controller
    {
        public IActionResult Index()
        {
            var principal = User as ClaimsPrincipal;

            var identity = User.Identity;

            var claimsIdentityInstance = identity as ClaimsIdentity;

            if (claimsIdentityInstance == null)
            {
                return View(new List<Claim>());
            }
            else
            {
                return View(claimsIdentityInstance.Claims.ToList());
            }
        }
    }
}