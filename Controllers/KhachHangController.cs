using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class KhachHangController : Controller
    {
        // Khai báo
        Model1 db = new Model1();
        // GET: KhachHang
        public ActionResult Index()
        {
            return View(db.Khachhangs.ToList());
        }
        // Mặc định là phương thức HTTPGet
        //action trả về một view
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        // Phương thức HTTPPost để nhận dữ liệu từ client gửi lên 
        [HttpPost]
        public ActionResult Create(Khachhang kh)
        {
            //Kiểm tra dữ liệu ở Model
            if(ModelState.IsValid)
            {
                //kh là dữ liệu đối tượng khách hàng mà client gửi lên
                db.Khachhangs.Add(kh);
                //Lưu thông tin thay đổi với database
                db.SaveChanges();
                // điều hướng đến trang index nếu thực hiện thành công
                return RedirectToAction("Index");
            }   
            //trả về view nhập thông tin khách hàng
            return View();
        }
        // tên biến là id được giữ nguyên, nếu kiểu dữ liệu của mã thay đổi thì
        //thay đổi theo, ở đây kiểu dữ liệu của MaKhachHang là string
        public ActionResult Edit(string id)
        {
            Khachhang kh = db.Khachhangs.Find(id);
            // trả về một view có chứa thông tin của khách hàng theo mã=id
            //để sửa thông tin khách hàng
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Khachhang kh)
        {
            if (ModelState.IsValid)
            {
                // sửa đổi dữ liệu
                db.Entry(kh).State = EntityState.Modified;
                //lưu thay đổi với database
                db.SaveChanges();
                // nếu sửa đổi thành công thì điều hướng về trtang index
                return RedirectToAction("Index");
            }
            //nếu không thành công thì trả về view edit
            return View(kh);
        }
    }
}