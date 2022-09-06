using Microsoft.AspNetCore.Mvc;

namespace ControlesdeContatos.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
