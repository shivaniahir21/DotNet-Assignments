using mvcPrac;
using mvcPrac.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcPrac.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDBContext _db;

        public TeacherController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Teacher> listofsubjects = _db.Teacher;
            return View(listofsubjects);
        }

        [HttpGet]
        public IActionResult Edit(int subjectid)
        {
            var subobj = _db.Teacher.Find(subjectid);
            return View(subobj);

        }

        [HttpPost]
        public IActionResult Edit(Teacher updatedvaluesobj)
        {
            _db.Teacher.Update(updatedvaluesobj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

       
    }
}
