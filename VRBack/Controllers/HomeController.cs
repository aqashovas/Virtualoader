using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VRBack.Models;
namespace VRBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly VirtualLoaderContext db = new VirtualLoaderContext();
        // GET: Home
        public ActionResult Index()
        {
            var model = db.Conferences.FirstOrDefault();
            return View(model);
        }
        public ActionResult Task()
        {
            var model = db.Conferences.FirstOrDefault();

            return View(model);
        }
    }
}