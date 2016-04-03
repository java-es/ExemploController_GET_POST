using System.Web.Mvc;

namespace ExemploControllersGETPOST.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult LoginGet(string email, string senha)
        {
            return Content("O Login é: " + email + " a senha é: " + senha);
        }

        [HttpPost]
        public ActionResult LoginPost(string email, string senha)
        {
            return Content("O Login é: " + email + " a senha é: " + senha);
        }
    }
}