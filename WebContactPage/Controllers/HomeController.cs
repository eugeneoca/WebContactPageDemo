using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebContactPage.Models;

namespace WebContactPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendForm(Entry entryModel)
        {
            using (WebContactDBEntities db = new WebContactDBEntities())
            {
                db.Entries.Add(entryModel);
                db.SaveChanges();
            }
            return Redirect("/contact");
        }
    }
}