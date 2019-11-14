using _20191114slnController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20191114slnController.Controllers
{
    public class ComplexBindController :Controller
    {
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product) {

            ViewBag.PId = product.PId;
            ViewBag.PName = product.PName;
            ViewBag.Price = product.Price;

            return View();
        }



    }
}