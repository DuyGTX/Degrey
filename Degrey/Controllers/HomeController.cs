using Degrey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Degrey.Controllers
{    
    public class HomeController : Controller
    {
        private ManageProductDBDataContext db; // Khai báo đối tượng DataContext

        public HomeController()
        {
            // Cung cấp chuỗi kết nối cơ sở dữ liệu cho constructor
            string connectionString = "Data Source=LAPTOP-DUY\\SQLEXPRESS;Initial Catalog=ManageStore;Integrated Security=True";
            db = new ManageProductDBDataContext(connectionString);
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
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult SanPham()
        {
            return View();
        }
        public ActionResult Store()
        {
            return View();
        }
        public ActionResult GioiThieu()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }
        public ActionResult ThongTinSoHuu()
        {
            return View();
        }
        public ActionResult HuongDanDatHang()
        {
            return View();
        }
        public ActionResult ChinhSachBaoMat()
        {
            return View();
        }
        public ActionResult ChinhSachVaQuyDinh()
        {
            return View();
        }
        public ActionResult Thongtinsanpham(int id)
        {
            // Sử dụng đối tượng db để truy cập cơ sở dữ liệu
            var product = db.ListProducts.FirstOrDefault(p => p.ID == id);

            if (product != null)
            {
                ViewBag.ProductID = product.ID;
                ViewBag.ProductName = product.ProductName;
                ViewBag.Price = product.Price;
                ViewBag.PriceRetail= product.PriceRetail;
                // Các thông tin sản phẩm khác
            }

            return View();
        }

    }
}