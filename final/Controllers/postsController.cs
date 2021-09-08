using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using final.Models;

namespace final.Controllers
{
    public class postsController : Controller
    {
        Model1 db = new Model1();
        // GET: posts
        public ActionResult addposts()
        {
            ViewBag.cate = db.catalog.ToList();
            List<catalog> catagories = db.catalog.ToList();
            SelectList st = new SelectList(catagories, "id" , "name");
            ViewBag.catagories = st;
            return View();
        }
    }
}