using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.IO;
using lyen;

namespace prjFileUpload.Controllers
{
    public class FileUploadController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(HttpPostedFileBase photo)
        {

            using (ezFileUpload upload = new ezFileUpload("~/Photos")) {

                upload.SaveUploadFile(photo);
            
            }



            /*
                //上傳圖檔
                string fileName = "";
            //檔案上傳
            if (photo != null)
            {
                if (photo.ContentLength > 0)
                {
                    //取得圖檔名稱
                    fileName = Path.GetFileName(photo.FileName);
                    var path = Path.Combine(Server.MapPath("~/Photos"), fileName);
                    photo.SaveAs(path);
                }
            }*/
            return RedirectToAction("ShowPhotos");
        }

        // ShowPhotos方法可顯示Photos資料夾下所有圖檔
        public string ShowPhotos()
        {
            string show = "";


            using (ezFileUpload upload = new ezFileUpload("~/Photos"))
            {
                show = upload.GetShowPhotosHtml("Create");
                
                    }


            /*
            // 建立可操作Photos資料夾的dir物件
            DirectoryInfo dir = new DirectoryInfo(Server.MapPath("~/Photos"));
            // 取得dir物件下的所有檔案(即Photos資料夾下)並放入finfo檔案資訊陣列
            FileInfo[] fInfo = dir.GetFiles();
            int n = 0;
            // 逐一將finfo檔案資訊陣列內的所有圖檔指定給show變數
            foreach (FileInfo result in fInfo)
            {
                n++;
                // 將目前取得的圖顯示在lblShow標籤內
                show += "<a href='../Photos/" + result.Name + "' target='_blank'><img src='../Photos/" + result.Name + "' width='90' height='60' border='0'></a>　";
                if (n % 4 == 0)    // 若顯示四個圖之後即跳一段落
                {
                    show += "<p>";
                }
            }
            // show變數再加上 '返回' Create動作方法的連結
            show += "<p><a href='Create'>返回</a></p>";
            */
            return show;
        }
    }
}