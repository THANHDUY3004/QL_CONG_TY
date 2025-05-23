using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QL_CONG_TY.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult PhongBan()
        {
            return View();
        }
        public ActionResult ChucVu()
        {
            return View();
        }
        public ActionResult NhanSu()
        {
            return View();
        }
        public ActionResult HopDong()
        {
            return View();
        }
        public ActionResult TrangChu()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Chưa có thông tin";
            return View();
        }
    }
}