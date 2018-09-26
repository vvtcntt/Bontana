using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bontana.Models;
 using Bontana.Models;
using Microsoft.EntityFrameworkCore;

namespace Bontana.Controllers.Admin.Maps
{
    public class MapsadController : Controller
    {
        BontanaContext db = new BontanaContext();
        // GET: Mapsad
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit()
        {
            if ((Request.Cookies["Username"] == null))
            {
                return RedirectToAction("LoginIndex", "Login");
            }
            if (ClsCheckRole.CheckQuyen(5, 2, int.Parse(Request.Cookies["Username"].Values["UserID"])) == true)
            {

                TblMaps TblMaps = db.TblMaps.First();

                if (TblMaps == null)
                {
                    return HttpNotFound();
                }

                return View(TblMaps);
            }
            else
            {
                return Redirect("/Users/Erro");

            }
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(TblMaps TblMaps, FormCollection collection)
        {

            if (ModelState.IsValid)
            {       string IdUser = Request.Cookies["Username"].Values["UserID"];
                    TblMaps.UserId = int.Parse(IdUser);
                    TblMaps.DateCreate = DateTime.Now;

                    int id = int.Parse(collection["idMaps"]);
                    TblMaps.Id = id;
                    db.Entry(TblMaps).State = EntityState.Modified;
                    db.SaveChanges();

                    
                   
               
                #region[Updatehistory]
                 #endregion
            }
            return View(TblMaps);
        }
    }
}