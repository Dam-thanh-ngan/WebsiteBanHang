using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class PhieuNhapController : Controller
    {
        Model1 db = new Model1();
        // GET: PhieuNhap
        public ActionResult Index()
        {
            return View(db.PhieuNhaps.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(PhieuNhap pn)
        {
            if (ModelState.IsValid)
            {
                db.PhieuNhaps.Add(pn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(string id)
        {
            PhieuNhap pn = db.PhieuNhaps.Find(id);
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PhieuNhap pn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pn);
        }
    }
}