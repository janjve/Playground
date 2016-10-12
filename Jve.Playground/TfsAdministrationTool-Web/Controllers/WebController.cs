using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TfsAdministrationTool_Web.Controllers
{
    public class WebController : Controller
    {
        // GET: SinglePage
        public ActionResult Index()
        {
            return RedirectToAction("Default");
        }

        public ActionResult Default()
        {
            return View();
        }     
    }
}