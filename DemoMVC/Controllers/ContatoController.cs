using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    [Route("contato")]
    public class ContatoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
