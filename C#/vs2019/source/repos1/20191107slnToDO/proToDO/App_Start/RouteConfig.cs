using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace proToDO
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
/*
 RegisterRoutes 靜態方法中使用 routes.MapRoute() 方法定義預設路由
，MapRoute() 方法分別定義三個參數，其說明如下：
1.name：設定路由名稱
2.url：設定網址對應到控制器(Controller)、動作(Action 方法)以及路由值(id，
　　　即Url 參數)規則
3.defaults：設定控制器(Controller)、動作(Action 方法)以及路由值(id，
　　　即Url 參數)的預設值

經由上面設定當程式執行時會啟動網址 http://localhost/Home/Index，為本專
案的首頁網址。
*/
