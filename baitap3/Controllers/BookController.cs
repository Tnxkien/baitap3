using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using baitap3.Models;

namespace baitap3.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult ListBook()
        {
            BookManagerContext context = new BookManagerContext();
            var listBook = context.Books.ToList();
            return View(listBook);
        }

        [Authorize]
        public ActionResult Buy(int id)
        {
            BookManagerContext context = new BookManagerContext();
            Book book = context.Books.SingleOrDefault(p => p.Id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View();
        }
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult Create(Book book, FormCollection collection)
        {
            BookManagerContext context = new BookManagerContext();
            Book book1 = context.Books.SingleOrDefault();
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                return RedirectToAction("ListBook");
            }

            return this.Create();
        }
        [Authorize]
        public ActionResult Edit(int id)
        {
            BookManagerContext context = new BookManagerContext();
            Book book1 = context.Books.SingleOrDefault(p => p.Id == id);
            var b = context.Books.First(m => m.Id == id);
            return View(b);
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            BookManagerContext context = new BookManagerContext();
            Book book1 = context.Books.SingleOrDefault(p => p.Id == id);
            var b = context.Books.First(m => m.Id == id);
            if (b != null)
            {
                UpdateModel(b);
                context.SaveChanges();
                return RedirectToAction("ListBook");
            }
            return this.Edit(id);
        }
        [Authorize]

        public ActionResult Delete(int id)
        {
            BookManagerContext context = new BookManagerContext();
            Book book1 = context.Books.SingleOrDefault(p => p.Id == id);
            var b = context.Books.First(m => m.Id == id);
            return View(b);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            BookManagerContext context = new BookManagerContext();
            Book book1 = context.Books.SingleOrDefault(p => p.Id == id);
            var b = context.Books.Where(x => x.Id == id).First();
            context.Books.Remove(b);
            context.SaveChanges();
            return RedirectToAction("ListBook");
        }

    }
}