using Degrey.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Degrey.Controllers
{    
    public class HomeController : Controller
    {
        DBDegreyStoreEntities db = new DBDegreyStoreEntities();

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
            var product = db.Products.FirstOrDefault(p => p.ProID == id);

            if (product != null)
            {
                ViewBag.ProID = product.ProID;
                ViewBag.ProName = product.ProName;
                ViewBag.Price = Convert.ToInt32(product.Price);
                ViewBag.Discount = product.Discount * 100;
                ViewBag.PriceSale = Convert.ToInt32(product.PriceSale);
                ViewBag.ProImage = product.ProImage;
                // Các thông tin sản phẩm khác
            }
            return View();
        }


        public ActionResult GetImageName(string ProductName) //dùng để lấy ra tên hình ảnh trong session  lưu bảng tạm trong giỏ hàng 
        {
            var product = db.Products.FirstOrDefault(p => p.ProName == ProductName);
            return Content(JsonConvert.SerializeObject(product.ProImage), "application/json");
        }


    }
}