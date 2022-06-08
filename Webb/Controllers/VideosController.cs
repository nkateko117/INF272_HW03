using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webb.Controllers
{
    public class VideosController : Controller
    {
        // GET: Videos
        public ActionResult Videos()
        {
            return View();
        }
    }
}