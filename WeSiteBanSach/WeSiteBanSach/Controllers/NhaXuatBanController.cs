using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeSiteBanSach.Models;

namespace WeSiteBanSach.Controllers
{
    public class NhaXuatBanController : Controller
    {
        QuanLyBanSachEntities db = new QuanLyBanSachEntities();
        // GET: NhaXuatBan
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult NhaXuatBanPartial()
        {
            return PartialView(db.NhaXuatBans.ToList());
        }
    }
}