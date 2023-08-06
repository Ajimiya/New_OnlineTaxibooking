using New_OnlineTaxibooking.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Razorpay.Api;

namespace New_OnlineTaxibooking.Controllers
{
    public class HomeController : Controller

    {
        private DB_MyonlinetaxinewoneEntities db = new DB_MyonlinetaxinewoneEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult about()
        {
            return View();
        }
        public ActionResult Admin()
        {
            return View();
        }
       public ActionResult Gallery() 
        {
            return View();  
        }

        public ActionResult Products(int? id)
        {

            ProductModel p = new ProductModel();

            p.cat = db.Categories.ToList();


            if (id == null)
            {
                p.pro = db.Products.ToList();
            }
            else
            {
                p.pro = db.Products.Where(z => z.Cat_Fid == id).ToList();
            }

            return View(p);
        }
        public ActionResult Success()
        {
            return View();
        }

        public ActionResult Adminlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Adminlog(Admin a)
        {
            int res = db.Admins.Where(x => x.Admin_Email == a.Admin_Email && x.Admin_Password == a.Admin_Password).Count();
            if (res == 1)
            {
                return RedirectToAction("Admin", "Home");
            }
            else
            {
                Response.Write("<script>alert('Invalid username or password');</script>");
                return View();
            }
        }
    }
}