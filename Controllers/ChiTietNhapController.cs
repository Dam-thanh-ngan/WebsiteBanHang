using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class ChiTietNhapController : Controller
    {
        Model1 db = new Model1();
        // GET: ChiTietNhap
        public ActionResult Index()
        {
            return View(db.ChiTietNhaps.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Create(ChiTietNhap ctn)
        {
            if (ModelState.IsValid)
            {
                db.ChiTietNhaps.Add(ctn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(string id)
        {
            ChiTietNhap ctn = db.ChiTietNhaps.Find(id);
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ChiTietNhap ctn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ctn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ctn);
        }
    }
}