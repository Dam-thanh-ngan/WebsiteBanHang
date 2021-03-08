using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Models;
namespace WebsiteBanHang.Controllers
{
    public class HangHoaController : Controller
    {
        Model1 db = new Model1();
        // GET: HangHoa
        public ActionResult Index()
        {
            return View(db.HangHoas.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(HangHoa hh)
        {
            if (ModelState.IsValid)
            {
                db.HangHoas.Add(hh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(string id)
        {
            HangHoa hh = db.HangHoas.Find(id);
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(HangHoa hh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hh);
        }
    }
}