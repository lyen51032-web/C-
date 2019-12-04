using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using prjPaging.Models;

namespace prjPaging.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
            int pageSize = 10;



        // GET: Home
        public ActionResult Index(int page = 1)
        {
            int currentPage = (page < 1) ? 1 : page;
            var products = db.產品資料.OrderBy(m => m.產品編號).ToList();
            var result = products.ToPagedList(currentPage, pageSize);

            return View(result);
        }
    }
}