using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaulCCA.BookLibrary;

namespace WebApplication1.Controllers
{
    public class BookManagerController : Controller
    {
        private static BookRepository _bookRepo = new BookRepository();
        
        // GET: BookManager
        public ActionResult Index()
        {
            return View(_bookRepo.ListAll());
        }

        // GET: BookManager/Details/5
        public ActionResult Details(int id)
        {
            return View(_bookRepo.GetById(id));
        }

        // GET: BookManager/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookManager/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book newBook, IFormCollection collection)
        {
            try
            {
                _bookRepo.Add(newBook);
            
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookManager/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_bookRepo.GetById(id));
        }

        // POST: BookManager/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book editbook, int id, IFormCollection collection)
        {
            try
            {
                _bookRepo.Edit(editbook);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookManager/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_bookRepo.GetById(id));
        }

        // POST: BookManager/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _bookRepo.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}