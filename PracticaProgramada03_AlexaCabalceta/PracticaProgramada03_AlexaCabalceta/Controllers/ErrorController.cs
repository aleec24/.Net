using Microsoft.AspNetCore.Mvc;

namespace PracticaProgramada03_AlexaCabalceta.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            if(statusCode == 404) {
                return View("NotFound");
            }
            else
            {
                return View("Error");
            }
        }
    }
}
