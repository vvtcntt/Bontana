using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bontana.Models;
using Bontana.Models;
namespace Bontana.Controllers.Admin
{
    public class AdminController : Controller
    {
        BontanaContext db = new BontanaContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult partialBanner()
        {
            ViewBag.donhang = db.TblOrder.Where(p => p.Status == false && p.Active==true).ToList().Count;
            return PartialView();
        }
    }
}