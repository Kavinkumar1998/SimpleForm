using Microsoft.AspNetCore.Mvc;
using SimpleForm.Models;
using SimpleForm.Models.Data;

namespace SimpleForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbcontext _context;

        public HomeController(AppDbcontext  context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }


        public IActionResult List()
        {
            var users = _context.Users.ToList();
            return View(users);
        }

        public IActionResult GetbyId(int id)
        {
            var data = _context.Users.Find(id);
            return View(data);
        }

        public IActionResult EditbyId(int id)
        {   
            var idata = _context.Users.Find(id);
            var data = _context.Users.Update(idata);
            _context.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Delete()
        {
            var data = _context.Users.Find(1);
            _context.Users.Remove(data);
            _context.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Deleteall()
        {
            var data = _context.Users.ToList();
            _context.Users.RemoveRange(data);
            _context.SaveChanges();
            return RedirectToAction("List");
        }

    }
}
