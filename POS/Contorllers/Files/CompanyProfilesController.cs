using Microsoft.AspNetCore.Mvc;

namespace POS.Contorllers.Files
{
    public class CompanyProfilesController : Controller
    {
        public IActionResult New()
        {
            return View();
        }
    }
}
