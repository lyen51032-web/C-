using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjLinq20191125.Controllers
{
    public class DefaultController : Controller
    {
        public string ShowArrayDesc() {

            int[] score = new int[] { 78, 99, 20, 100, 66 };
            string show = "";
            var result = score.OrderByDescending(m => m);
            foreach (var m in score) {
                show += m + ",";
            }
            show += "<br />";
            show += "總和:" + result.Sum();
            return show;
            
        
        
        }

        public string ShowArrayAsc()
        {

            int[] score = new int[] { 78, 99, 20, 100, 66 };
            string show = "";
            var result = score.OrderBy(m => m);
            foreach (var m in score)
            {
                show += m + ",";
            }
            show += "<br />";
            show += "平均:" + result.Average();
            return show;



        }


        public string LoginMember(string uid, string pwd)
        {

            Member[] members = new Member[] {
            new Member{ UId = "tom",Pwd = "123",Name="湯姆"},
            new Member{ UId = "jasper",Pwd = "456",Name="賈斯柏"},
            new Member{ UId = "mary",Pwd = "789",Name="瑪莉"}
                    };
            var result = members.Where(m => m.UId == uid && m.Pwd == pwd).FirstOrDefault();
            string show = "";
            if (result != null)
            {
                show = result.Name + "歡迎進入系統";
            }
            else
            {
                show = "帳號或密碼錯誤";
            }
            return show;

        }
    }
}