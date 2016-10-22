using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeSiteBanSach.Models;

namespace WeSiteBanSach.Controllers
{
    public class ChuDeController : Controller
    {
        QuanLyBanSachEntities db = new QuanLyBanSachEntities();
        // GET: ChuDe
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult ChuDePartial()
        {
            var listChuDe = db.ChuDes.Take(5).ToList();
            return PartialView(listChuDe);
        }
        public ViewResult SachTheoChuDe(int machude = 0)
        {
            ChuDe cd = db.ChuDes.SingleOrDefault(s => s.MaChuDe == machude);
            if (cd == null) {
                Response.StatusCode = 404;
                return null;
            }
            List<Sach> sachs = db.Saches.Where(s => s.MaChuDe == machude).OrderBy(g => g.GiaBan).ToList();
            if (sachs.Count == 0)
            {
                ViewBag.Sach = "Không có sách nào thuộc chủ đề này";
            }
            return View(sachs);
        }
    }
}