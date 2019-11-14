using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20191114slnController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public string ShowAry() {

            int[] score = new int[] { 78, 99, 20, 100, 66 };
            string show = "";
            int sum = 0;
            foreach (var m in score) {
                show += m + ",";
                sum += m;

            }

            show += "<br />";
            show += "總和:" + sum;
            return show;

        }

        public string ShowImages() {
            string show = "";
            for (int i=1; i <= 8; i++) { 
            show +=string.Format("<img src='../images/{0}.jpg' width='150'> ",i);
            }
            return show;
        }


        public string ShowImageIndex(int index)
        {

            string[] name = new string[] { "櫻桃鴨", "鴨油高麗菜", "鴨油麻婆豆腐", "櫻桃鴨握壽司", "片皮鴨捲三星蔥", "三杯鴨", "櫻桃鴨片肉", "慢火白菜燉鴨湯" };


            string show = string.Format("<p align='center'><img src='../images/{0}.jpg'><br>{1}</p>", index, name[index - 1]);

            return show;
        }

        public ActionResult Action1() {

            ViewData["CompanyName"] = "大才全資訊";
            return View();
        }
        public ActionResult Action2()
        {

            ViewBag.CompanyName = "大才全資訊";
            return View();
        }
        public ActionResult Action3()
        {

            TempData["CompanyName"] = "大才全資訊";
            return RedirectToAction("Action4");
        }

        public ActionResult Action4()
        {
            return View();
        }
        public ActionResult Action5()
        {
            return View();
        }




    }
}