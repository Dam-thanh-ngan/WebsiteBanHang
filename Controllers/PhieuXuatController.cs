using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class PhieuXuatController : Controller
    {
        Model1 db = new Model1();
        // GET: PhieuXuat
        public ActionResult Index()
        {
            return View(db.PhieuXuats.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Create(PhieuXuat px)
        {
            if(ModelState.IsValid)
            {
                db.PhieuXuats.Add(px);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(string id)
        {
            PhieuXuat px = db.PhieuXuats.Find(id);
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PhieuXuat px)
        {
            if (ModelState.IsValid)
            {
                db.Entry(px).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(px);
        }
    }
}