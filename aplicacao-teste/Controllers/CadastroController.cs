using Microsoft.AspNetCore.Mvc;
using aplicacao_teste.Models;

namespace aplicacao_teste.Controllers
{
    public class CadastroController : Controller
    {
        private static List<UserViewModel> _users = new List<UserViewModel>();

        public IActionResult Index()
        {
            return View(_users);
        }

        public IActionResult SignUp()
        {
            UserViewModel user = new UserViewModel();
            return View(user);
        }

        public IActionResult SignedUp(UserViewModel user)
        {
            _users.Add(user);
            return View(user);
        }
    }
}
