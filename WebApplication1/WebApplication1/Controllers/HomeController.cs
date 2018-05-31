using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using PaulCCA.BookLibrary;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private BookRepository _boRepo = new BookRepository();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            var myBook = new Book
            {
                Author = "Kobe",
                Title = "Lakers",
                Genre = "SciFi",
            };

            _boRepo.Add(myBook);

            return View(myBook);
        }

        [Authorize]

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
