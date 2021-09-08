using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using final.Models;

namespace final.Controllers
{
    public class userController : Controller
    {
        Model1 db = new Model1();
        public ActionResult register()
        {
            ViewBag.cate = db.catalog.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult register(user s ,HttpPostedFileBase photo)
        {
            photo.SaveAs(Server.MapPath("~/attach/"+photo.FileName));
            s.photo = photo.FileName;
            user a = db.user.Where(n => n.email == s.email).FirstOrDefault();
            if (a != null)
            {
                ViewBag.message = "Already Exist";
                return View();
            }
            if (ModelState.IsValid)
            {
                db.user.Add(s);
                db.SaveChanges();
                return RedirectToAction("login");
            }
            return View();
        }
        public ActionResult login()
        {
            ViewBag.cate = db.catalog.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult login(user s)
        {
            user a = db.user.Where(n => n.email == s.email && n.password == s.password).FirstOrDefault();
            if (a != null)
            {
                return RedirectToAction("index", "Home");
            }
            else
            {
                ViewBag.message = "email or passwrd is incorrect";
                return View();
            }
            
        }
    }
}