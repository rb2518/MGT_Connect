using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(admin_users u )
        {
            if(ModelState.IsValid)
            {
                using (AdminContext ac = new AdminContext())
                {
                    var v = ac.admin_users.Where(a => a.email.Equals(u.email) && a.password.Equals(u.password)).SingleOrDefault();
                    if (v != null)
                    {
                       
                        Session["id"] = u.id;
                        Response.Redirect("~/Account/Index");
                    }
                    else
                        ViewBag.Message = "Invalid Credentials.";
                }
            }
            return View();
        }

        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}