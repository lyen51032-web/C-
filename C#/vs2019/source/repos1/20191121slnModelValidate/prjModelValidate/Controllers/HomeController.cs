
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using prjModelValidate.Models;

namespace prjModelValidate.Controllers
{
    public class HomeController : Controller
    {
        dbStudentEntities db = new dbStudentEntities();
        // GET: Home
        public ActionResult Index()
        {
            var students = db.tStudent.ToList();
            return View(students);
        }
        // GET: Create
        public ActionResult Create()
        {
            return View();
        }
        // POST:Create
        [HttpPost]
        public ActionResult Create(tStudent stu)
        {
            if (ModelState.IsValid)
            {
                db.tStudent.Add(stu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stu);
        }
        // GET: Delete
        public ActionResult Delete(string id)
        {
            var stu = db.tStudent.Where(m => m.fStuid == id).FirstOrDefault();
            db.tStudent.Remove(stu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}