using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeSiteBanSach.Models;

namespace WeSiteBanSach.Controllers
{
    public class SachController : Controller
    {
        QuanLyBanSachEntities db = new QuanLyBanSachEntities();
        // GET: Sach
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult SachMoiPartial()
        {
            var listSachMoi = db.Saches.Take(3).ToList();
            return PartialView(listSachMoi);
        }

        public ViewResult XemChiTiet(int masach = 0)
        {
            Sach sach = db.Saches.SingleOrDefault(s => s.MaSach == masach);
            if (sach == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sach);
        }
    }
}