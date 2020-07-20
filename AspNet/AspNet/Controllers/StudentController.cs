using AspNet.Data;
using AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNet.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        private readonly StudentContext _context;
        public StudentController()
        {
            _context = new StudentContext();
        }
        public ActionResult Index()
        {
            var list = _context.Students.ToList();
            return View(list);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            
            if (_context.Students.Any(s => s.Phone == student.Phone))
            {
                ModelState.AddModelError("Phone", "Bu nomre artiq qeydiyyatda movcuddur.");
            }
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();

                return RedirectToAction("index");
            }
            return View(student);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Student student = _context.Students.Find(id);

            return View(student);
        }
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (student.Age > 50)
            {
                return View();

            }
            if (_context.Students.Any(s => s.Phone == student.Phone))
            {
                ModelState.AddModelError("Phone", "Bu nomre artiq qeydiyyatda movcuddur.");
            }

            _context.Entry(student).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
            
        }
        public ActionResult Delete(int id)
        {
            var selectedStudent = _context.Students.Find(id);
            _context.Students.Remove(selectedStudent);
            _context.SaveChanges();
            return RedirectToAction("Index"); 
        }
    }
}