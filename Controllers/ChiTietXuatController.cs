using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Models;
namespace WebsiteBanHang.Controllers
{
    public class ChiTietXuatController : Controller
    {
        Model1 db = new Model1();
        // GET: ChiTietXuat
        public ActionResult Index()
        {
            return View(db.ChiTietXuats.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ChiTietXuat ctx)
        {
            if (ModelState.IsValid)
            {
                db.ChiTietXuats.Add(ctx);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(string id)
        {
            ChiTietXuat ctx = db.ChiTietXuats.Find(id);
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ChiTietXuat ctx)
        {
            if(ModelState.IsValid)
            {
                ChiTietXuat.Entry(ctx).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ctx);
        }
    }
}