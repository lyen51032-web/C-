using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjMultiTable.Models;

namespace prjMultiTable.Controllers
{
    public class HomeController : Controller
    {
        dbEmployeeEntities db = new dbEmployeeEntities();
        public ActionResult Index(int depId = 1)
        {
            ViewBag.DepName = db.tDepartment.
                Where(m => m.fDepId == depId).
                FirstOrDefault().fDepName + "部門";

            CVMDepEmp vm = new CVMDepEmp()
            {
                department = db.tDepartment.OrderBy(m => m.fDepName).ToList(),
                employee = db.tEmployee.
                Where(m => m.fDepId == depId).ToList()
            };

            return View(vm);
        }

        public ActionResult Create()
        {
            return View(db.tDepartment.ToList());
        }

        [HttpPost]
        public ActionResult Create(tEmployee emp)
        {
            try
            {
                db.tEmployee.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index", new { depId = emp.fDepId });
            }
            catch (Exception ex)
            {
                string str_message = ex.Message;
            }
            return View(emp);
        }

        public ActionResult Delete(string fEmpId)
        {
            var emp = db.tEmployee.Where(m => m.fEmpId == fEmpId).FirstOrDefault();
            db.tEmployee.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("Index", new { depId = emp.fDepId });
        }
    }
}