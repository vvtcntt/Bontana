﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bontana.Models;
using PagedList;
using PagedList.Mvc;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using Bontana.Models;

namespace Bontana.Controllers.Admin.Banks
{
    public class OrderadController : Controller
    {

        // GET: Banks
        private BontanaContext db = new BontanaContext();
        public ActionResult Index(int? page, string id, FormCollection collection)
        {
            if ((Request.Cookies["Username"] == null))
            {
                return RedirectToAction("LoginIndex", "Login");
            }
            if (ClsCheckRole.CheckQuyen(11, 0, int.Parse(Request.Cookies["Username"].Values["UserID"])) == true)
            {
                var ListOrd = db.TblOrder.OrderByDescending(p=>p.DateByy).ToList();

                const int pageSize = 20;
                var pageNumber = (page ?? 1);
                // Thiết lập phân trang
                var ship = new PagedListRenderOptions
                {
                    DisplayLinkToFirstPage = PagedListDisplayMode.Always,
                    DisplayLinkToLastPage = PagedListDisplayMode.Always,
                    DisplayLinkToPreviousPage = PagedListDisplayMode.Always,
                    DisplayLinkToNextPage = PagedListDisplayMode.Always,
                    DisplayLinkToIndividualPages = true,
                    DisplayPageCountAndCurrentLocation = false,
                    MaximumPageNumbersToDisplay = 5,
                    DisplayEllipsesWhenNotShowingAllPageNumbers = true,
                    EllipsesFormat = "&#8230;",
                    LinkToFirstPageFormat = "Trang đầu",
                    LinkToPreviousPageFormat = "«",
                    LinkToIndividualPageFormat = "{0}",
                    LinkToNextPageFormat = "»",
                    LinkToLastPageFormat = "Trang cuối",
                    PageCountAndCurrentLocationFormat = "Page {0} of {1}.",
                    ItemSliceAndTotalFormat = "Showing items {0} through {1} of {2}.",
                    FunctionToDisplayEachPageNumber = null,
                    ClassToApplyToFirstListItemInPager = null,
                    ClassToApplyToLastListItemInPager = null,
                    ContainerDivClasses = new[] { "pagination-container" },
                    UlElementClasses = new[] { "pagination" },
                    LiElementClasses = Enumerable.Empty<string>()
                };
                ViewBag.ship = ship;
                if (Session["Thongbao"] != null && Session["Thongbao"] != "")
                {

                    ViewBag.thongbao = Session["Thongbao"].ToString();
                    Session["Thongbao"] = "";
                }
                if (collection["btnDelete"] != null)
                {
                    foreach (string key in Request.Form.Keys)
                    {
                        var checkbox = "";
                        if (key.StartsWith("chk_"))
                        {
                            checkbox = Request.Form["" + key];
                            if (checkbox != "false")
                            {
                                if (ClsCheckRole.CheckQuyen(12, 3, int.Parse(Request.Cookies["Username"].Values["UserID"])) == true)
                                {
                                    int ids = Convert.ToInt32(key.Remove(0, 4));
                                    TblOrder tblord = db.TblOrder.Find(ids);
                                    db.TblOrder.Remove(tblord);
                                    db.SaveChanges();
                                    return RedirectToAction("Index");
                                }
                                else
                                {
                                    return Redirect("/Users/Erro");

                                }
                            }
                        }
                    }
                }
                return View(ListOrd.ToPagedList(pageNumber, pageSize));
            }
            else
            {
                return Redirect("/Users/Erro");

            }
        }
        public ActionResult UpdateOrder(string id, string Active)
        {
            if (ClsCheckRole.CheckQuyen(12, 2, int.Parse(Request.Cookies["Username"].Values["UserID"])) == true)
            {

                int ids = int.Parse(id);
                var TblOrder = db.TblOrder.Find(ids);
                TblOrder.Active = bool.Parse(Active);
                 db.SaveChanges();
                var result = string.Empty;
                result = "Thành công";
                return Json(new { result = result });
            }
            else
            {
                var result = string.Empty;
                result = "Bạn không có quyền thay đổi tính năng này";
                return Json(new { result = result });

            }

        }
        public ActionResult DeleteOrder(int id)
        {
            if (ClsCheckRole.CheckQuyen(12, 3, int.Parse(Request.Cookies["Username"].Values["UserID"])) == true)
            {
                TblOrder TblOrder = db.TblOrder.Find(id);
                var result = string.Empty;
                db.TblOrder.Remove(TblOrder);
                db.SaveChanges();
 
                result = "Bạn đã xóa thành công.";
                return Json(new { result = result });
            }
            else
            {
                var result = string.Empty;
                result = "Bạn không có quyền thay đổi tính năng này";
                return Json(new { result = result });

            }
        }
        public ActionResult Delete(int id)
        {
            if (ClsCheckRole.CheckQuyen(12, 3, int.Parse(Request.Cookies["Username"].Values["UserID"])) == true)
            {
                TblOrder TblOrder = db.TblOrder.Find(id);
                var result = string.Empty;
                db.TblOrder.Remove(TblOrder);
                db.SaveChanges();
 
                result = "Bạn đã xóa thành công.";
                return RedirectToAction("Index");
            }
            else
            {
                var result = string.Empty;
                result = "Bạn không có quyền thay đổi tính năng này";
                return RedirectToAction("Index");

            }
            return RedirectToAction("Index");
        }
        public ActionResult Detail(int id)
        {
            TblOrder tbldetail = db.TblOrder.Find(id);
            
            tbldetail.Status = true;
            db.SaveChanges();
 
            string chuoi = "";

            chuoi += "<table align=\"left\" cellpadding=\"2\">";
            chuoi += "<tr class=\"top\">";
            chuoi += "<td class=\"Name\">Tên sản phẩm</td>";
            chuoi += "<td class=\"Price\">Đơn giá</td>";
            chuoi += "<td class=\"Ord\">SL</td>";
            chuoi += "<td class=\"PriceSale\">Thành tiền</td>";
            chuoi += "</tr>";
            var listOrrder = db.TblOrderDetail.Where(p => p.IdOrder == id).ToList();
          
                for (int i = 0; i < listOrrder.Count; i++)
                {
                    chuoi += "<tr class=\"row" + listOrrder[i].Id + "\" >";
                    chuoi += "<td class=\"Name\" >";
                    int idPro=int.Parse(listOrrder[i].IdProduct.ToString());
                    var product = db.TblProduct.Find(idPro);
                    chuoi += "<a href=\"/San-pham/" + product.Tag + "\" title=\"" + product.Name + "\" target=\"_blank\" id=\"UpdateOrd" + product.Id + "\"><img src=\"" + product.ImageLinkThumb + "\" alt=\"" + product.Name + "\" title=\"" + product.Name + "\" /></a>";
                    chuoi += "<a href=\"/San-pham/" + product.Tag + "\" title=\"" + product.Name + "\" target=\"_blank\" class=\"Namepd\">" + product.Name + "</a>";
                     chuoi += "</td>";
                    chuoi += "<td class=\"Price\"><span>" + string.Format("{0:#,#}", listOrrder[i].Price) + " vnđ</span></td>";
                    chuoi += "<td class=\"Ord\"><input type=\"number\" name=\"Ord\"  class=\"txtOrd" + listOrrder[i].Id + "\" value=\"" + listOrrder[i].Quantily + "\"  /></td>";
                    chuoi += "<td class=\"PriceSale\"><span id=\"Gia" + listOrrder[i].Id + "\">" + string.Format("{0:#,#}", listOrrder[i].SumPrice) + " vnđ</span></td>";
                    chuoi += "</tr>";
                }

                chuoi += "</table>";
                chuoi += "  <div class=\"Sum\">";
                chuoi += "  <div class=\"LeftSUM\">";
                chuoi += "      <span>Bạn có <span class=\"count\">" + listOrrder.Count + "</span> sản phẩm trong giỏ hàng</span>";
                chuoi += " </div>";
                chuoi += " <div class=\"RightSUM\">";
                chuoi += "  <span class=\"Sum1\">Tổng cộng :  <span class=\"tt\">" + string.Format("{0:#,#}", db.TblOrder.Find(id).Tolar) + "</span> vnđ </span>";
                chuoi += "  <span class=\"Sum2\">Thành tiền: <span class=\"tt\">" + string.Format("{0:#,#}", db.TblOrder.Find(id).Tolar) + "</span> vnđ </span>";
                chuoi += "  </div>";
            
 
            chuoi += "</div>";
            chuoi += "<div class=\"OrderNows\">";
             


            chuoi += "  </div>";
            ViewBag.chuoi = chuoi;
            return View(db.TblOrder.Find(id));
        }
        public ActionResult ActiveOrder(int id)
        {
            TblOrder tbldetail = db.TblOrder.Find(id); 
            tbldetail.Status = true;
            db.SaveChanges();
            return View();
        }
         
    }
}