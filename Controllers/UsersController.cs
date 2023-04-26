using Microsoft.AspNetCore.Mvc;
using MvcStaryApp.Models.Db;
using System.Threading.Tasks;

namespace MvcStaryApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly IBlogRepository _repo;

        public UsersController(IBlogRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var authors = await _repo.GetUsers();
            return View(authors);
        }
        public async Task<IActionResult> Register()
        {
            return View();
        }
    }
}
