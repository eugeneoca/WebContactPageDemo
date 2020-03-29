using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebContactPage.Models;

namespace WebContactPage.Controllers
{
    public class RecordController : Controller
    {

        public ActionResult Index()
        {
            using (WebContactDBEntities db = new WebContactDBEntities())
            {
                List<Entry> records = db.Entries.ToList();
                return View(records);
            }
        }
    }
}