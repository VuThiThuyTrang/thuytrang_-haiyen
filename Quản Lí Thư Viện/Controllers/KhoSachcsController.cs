using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Quản_Lí_Thư_Viện.Models;

namespace Quản_Lí_Thư_Viện.Controllers
{
    public class KhoSachcsController : Controller
    {
        private QLTHUVIENDbContext db = new QLTHUVIENDbContext();

        // GET: KhoSachcs
        public ActionResult Index()
        {
            return View(db.KhoSachcs.ToList());
        }

        // GET: KhoSachcs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhoSachcs khoSachcs = db.KhoSachcs.Find(id);
            if (khoSachcs == null)
            {
                return HttpNotFound();
            }
            return View(khoSachcs);
        }

        // GET: KhoSachcs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KhoSachcs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaKho,TenKho,GhiChu")] KhoSachcs khoSachcs)
        {
            if (ModelState.IsValid)
            {
                db.KhoSachcs.Add(khoSachcs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(khoSachcs);
        }

        // GET: KhoSachcs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhoSachcs khoSachcs = db.KhoSachcs.Find(id);
            if (khoSachcs == null)
            {
                return HttpNotFound();
            }
            return View(khoSachcs);
        }

        // POST: KhoSachcs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaKho,TenKho,GhiChu")] KhoSachcs khoSachcs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khoSachcs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(khoSachcs);
        }

        // GET: KhoSachcs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhoSachcs khoSachcs = db.KhoSachcs.Find(id);
            if (khoSachcs == null)
            {
                return HttpNotFound();
            }
            return View(khoSachcs);
        }

        // POST: KhoSachcs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KhoSachcs khoSachcs = db.KhoSachcs.Find(id);
            db.KhoSachcs.Remove(khoSachcs);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
