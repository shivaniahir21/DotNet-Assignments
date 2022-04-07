using tempMVC;
using tempMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tempMVC.data;
using Microsoft.EntityFrameworkCore;

namespace tempMVC.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDBContext _db;

        public TeacherController(ApplicationDBContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(string searchString) {
            var teachers = from t in _db.Teacher
            select t;
            if (!String.IsNullOrEmpty(searchString)) {
                teachers = teachers.Where(s => s.name.Contains(searchString));
            }
            return View(await teachers.ToListAsync());
        }

         [HttpGet]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(Teacher newTeacher)
        {
            _db.Teacher.Add(newTeacher);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        
        [HttpGet]
        public IActionResult Edit(int teacherid)
        {
            var subobj = _db.Teacher.Find(teacherid);
            return View(subobj);

        }

        [HttpPost]
        public IActionResult Edit(Teacher updatedvaluesobj)
        {
            _db.Teacher.Update(updatedvaluesobj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }


               //Get Delete
        public IActionResult Delete(int Teacherid)
        {

            var studobj = _db.Teacher.Find(Teacherid);
            return View(studobj);
        }


        [HttpPost]
        public IActionResult DeletePost(int ID)
        {
            var studobj = _db.Teacher.Find(ID);

            if (ModelState.IsValid)
            {

                _db.Teacher.Remove(studobj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studobj);
        }





       
    }
}
