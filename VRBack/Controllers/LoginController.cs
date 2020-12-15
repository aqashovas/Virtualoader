using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using VRBack.Models;

namespace VRBack.Controllers
{
    public class LoginController : Controller
    {
        private readonly VirtualLoaderContext db = new VirtualLoaderContext();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            if (ModelState.IsValid)
            {
                Admin adm = db.Admins.FirstOrDefault(a => a.Username == admin.Username);

                if (adm != null)
                {
                    if (Crypto.VerifyHashedPassword(adm.Password, admin.Password))
                    {
                        Session["login"] = true;
                        Session["UserId"] = adm.Id;
                        return RedirectToAction("index", "conferences");
                    }
                }

                ModelState.AddModelError("summary", "Email or password incorret");
            }

            return View(admin);
        }


        public ActionResult Createpass()
        {
            string a = Crypto.HashPassword("123");
            return Content(a);
        }
    }
}