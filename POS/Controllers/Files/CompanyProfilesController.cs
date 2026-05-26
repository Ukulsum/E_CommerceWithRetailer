using Microsoft.AspNetCore.Mvc;

namespace POS.Controllers.Files
{
    public class CompanyProfilesController : Controller
    {
        public IActionResult New()
        {
            return View();
        }
    }
}
