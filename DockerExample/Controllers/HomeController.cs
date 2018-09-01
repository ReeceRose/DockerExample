using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DockerExample.Models;

namespace DockerExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = new UserIndexModel()
            {
                Users = _context.Users
            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
