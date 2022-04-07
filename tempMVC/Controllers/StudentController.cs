using tempMVC;
using tempMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tempMVC.data;

namespace tempMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDBContext _db;

        public StudentController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Student> listofsubjects = _db.Student;
            return View(listofsubjects);
        }

        [HttpGet]
        public IActionResult Edit(int Studentid)
        {
            var subobj = _db.Student.Find(Studentid);
            return View(subobj);

        }

        [HttpPost]
        public IActionResult Edit(Student updatedvaluesobj)
        {
            _db.Student.Update(updatedvaluesobj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }


               //Get Delete
        public IActionResult Delete(int Studentid)
        {

            var studobj = _db.Student.Find(Studentid);
            return View(studobj);
        }


        [HttpPost]
        public IActionResult DeletePost(int ID)
        {
            var studobj = _db.Student.Find(ID);

            if (ModelState.IsValid)
            {

                _db.Student.Remove(studobj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studobj);
        }





       
    }
}
