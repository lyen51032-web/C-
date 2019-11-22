using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _20191120prjShoppingCar.Models;

namespace _20191120prjShoppingCar.Controllers
{
    public class HomeController : Controller
    {
        dbShoppingCarEntities db = new dbShoppingCarEntities();
        // GET: Home
        public ActionResult Index()
        {
            var products = db.tProduct.ToList();
            if (Session["Member"] == null) {
                return View("Index","_Layout",products);
                            }

            return View("Index", "_LayoutMember", products);

                               }

        //GET:HOME/login
        public ActionResult Login() {
            return View();
        }
        //POST:HOME/Login
        [HttpPost]
        public ActionResult Login(string fUserId, string fPwd) {
            
            //取得帳密且已註冊
            var member = db.tMember.Where(m => m.fUserId == fUserId && m.fPwd == fPwd).FirstOrDefault();

            //未註冊帳號
            if (member == null) {

                ViewBag.Message = "帳密錯誤，登入失敗";
                return View();
            }
            Session["WelCome"] = member.fName + "歡迎光臨";
            Session["Member"] = member;
            return RedirectToAction("Index");

        }


        //GET:HOME/Register
        public ActionResult Register() {
            return View();
        }

        //POST:HOME/Register
        [HttpPost]
        public ActionResult Register(tMember pMember) {

            if (ModelState.IsValid == false) {

                return View();
            }
            //如果會員是對的,回傳
            var member = db.tMember.Where(m => m.fUserId == pMember.fUserId).FirstOrDefault();
            //會員未註冊跳到畫面
            if (member == null) {
                db.tMember.Add(pMember);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            ViewBag.Message = "此帳號已有人使用，註冊失敗";



            return View();
        }





    }
}