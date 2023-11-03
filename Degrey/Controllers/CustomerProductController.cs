using Degrey.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Degrey.Controllers
{
    public class CustomerProductController : Controller
    {
        // GET: Product
        private DBDegreyStoreEntities db = new DBDegreyStoreEntities();
        // GET: Products
        public ActionResult SanPham()
        {
            var products = db.Products;
            return View(products.ToList());
        }
        public ActionResult ThongTinSanPham(int? id)
        {
            if (id == null)
            {
                return new
                HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        public ActionResult ThongTinSP(int id)
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