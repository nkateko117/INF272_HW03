using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webb.Models;
using System.IO;


namespace Webb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file, string RadioFType)
        {
            string RadioType = RadioFType;

            if (file != null && file.ContentLength > 0)
            {
                if (RadioType == "Document")
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("/Media/Files/"), fileName);
                    file.SaveAs(path);
                }

                else if (RadioType == "Image")
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("/Media/Images/"), fileName);
                    file.SaveAs(path);
                }


            }

            return RedirectToAction("Index");
        }
    }
}