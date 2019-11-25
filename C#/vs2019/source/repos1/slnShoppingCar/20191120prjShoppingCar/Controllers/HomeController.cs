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

        //GET:Index/Logout
        public ActionResult Logout() {

            Session.Clear();//清除登入資訊
            return RedirectToAction("Index");
        }

        //GET:Index/ShoppigCar
        public ActionResult ShoppingCar() {

            string fUserId = (Session["Member"] as tMember).fUserId;
            var orderDetails = db.tOrderDetail.Where(m => m.fUserId == fUserId && m.fIsApproved == "否").ToList();


            return View("ShoppingCar", "_LayoutMember", orderDetails);
        }

        //Get:Index/AddCar
        public ActionResult AddCar(string fPId) {
            string fUserId = (Session["Member"] as tMember).fUserId;
            var currentCar = db.tOrderDetail.Where(m => m.fPId == fPId && m.fIsApproved == "否" && m.fUserId == fUserId).FirstOrDefault();
            //如果不是購物車狀態
            if (currentCar == null)
            {
                //選購產品指定給product
                var product = db.tProduct.Where(m => m.fPId == m.fPId).FirstOrDefault();

                //確認是否為購物車狀態
                tOrderDetail orderDetail = new tOrderDetail();
                orderDetail.fUserId = fUserId;
                orderDetail.fPId = product.fPId;
                orderDetail.fName = product.fName;
                orderDetail.fPrice = product.fPrice;
                orderDetail.fQty = 1;
                orderDetail.fIsApproved = "否";
                db.tOrderDetail.Add(orderDetail);

            }
            else {
                //購物車狀態，該產品數量+1
                currentCar.fQty += 1;
                            }
            db.SaveChanges();
            return RedirectToAction("ShoppingCar");
        }

        //Get:Index/DeleteCar
        public ActionResult DeleteCar(int fId) {
            //找出要刪除的商品
            var orderDetail = db.tOrderDetail.Where(m => m.fId == fId).FirstOrDefault();
            db.tOrderDetail.Remove(orderDetail);
            db.SaveChanges();
           

            return RedirectToAction("ShoppingCar");
        }

        //Post:Index/ShoppingCar
        [HttpPost]
        public ActionResult ShoppingCar(string fReceiver, string fEmail, string fAddress)
        {
            //找出會員帳號並指定給fUserId
            string fUserId = (Session["Member"] as tMember).fUserId;
            //建立唯一的識別值並指定給guid變數，用來當做訂單編號
            //tOrder的fOrderGuid欄位會關聯到tOrderDetail的fOrderGuid欄位
            //形成一對多的關係，即一筆訂單資料會對應到多筆訂單明細
            string guid = Guid.NewGuid().ToString();
            //建立訂單主檔資料
            tOrder order = new tOrder();
            order.fOrderGuid = guid;
            order.fUserId = fUserId;
            order.fReceiver = fReceiver;
            order.fEmail = fEmail;
            order.fAddress = fAddress;
            order.fDate = DateTime.Now;
            db.tOrder.Add(order);
            //找出目前會員在訂單明細中是購物車狀態的產品
            var carList = db.tOrderDetail.Where(m => m.fIsApproved == "否" && m.fUserId == fUserId).ToList();
            //將購物車狀態產品的fIsApproved設為"是"，表示確認訂購產品
            foreach (var item in carList)
            {
                item.fOrderGuid = guid;
                item.fIsApproved = "是";
            }
            //完成訂單主檔和訂單明細的更新，更新資料庫，異動tOrder和tOrderDetail
            db.SaveChanges();
            //執行Home控制器的OrderList動作方法
            return RedirectToAction("OrderList");
        }

        //Get:Home/OrderList
        public ActionResult OrderList()
        {
            //找出會員帳號並指定給fUserId
            string fUserId = (Session["Member"] as tMember).fUserId;
            //找出目前會員的所有訂單主檔記錄並依照fDate進行遞增排序
            //將查詢結果指定給orders
            var orders = db.tOrder.Where(m => m.fUserId == fUserId).OrderByDescending(m => m.fDate).ToList();
            //目前會員的訂單主檔
            //指定OrderList.cshtml套用_LayoutMember.cshtml，View使用orders模型
            return View("OrderList", "_LayoutMember", orders);
        }

        //Get:Index/OrderDetail
        public ActionResult OrderDetail(string fOrderGuid)
        {
            //根據fOrderGuid找出和訂單主檔關聯的訂單明細，並指定給orderDetails
            var orderDetails = db.tOrderDetail
                .Where(m => m.fOrderGuid == fOrderGuid).ToList();
            //目前訂單明細
            //指定OrderDetail.cshtml套用_LayoutMember.cshtml，View使用orderDetails模型
            return View("OrderDetail", "_LayoutMember", orderDetails);
        }
    }


}

