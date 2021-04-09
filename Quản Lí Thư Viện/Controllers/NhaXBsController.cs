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
    public class NhaXBsController : Controller
    {
        private QLTHUVIENDbContext db = new QLTHUVIENDbContext();

        // GET: NhaXBs
        public ActionResult Index()
        {
            return View(db.NhaXBs.ToList());
        }

        // GET: NhaXBs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaXB nhaXB = db.NhaXBs.Find(id);
            if (nhaXB == null)
            {
                return HttpNotFound();
            }
            return View(nhaXB);
        }

        // GET: NhaXBs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhaXBs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TenNhaXB,MaNhaXB,DiaChi")] NhaXB nhaXB)
        {
            if (ModelState.IsValid)
            {
                db.NhaXBs.Add(nhaXB);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhaXB);
        }

        // GET: NhaXBs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaXB nhaXB = db.NhaXBs.Find(id);
            if (nhaXB == null)
            {
                return HttpNotFound();
            }
            return View(nhaXB);
        }

        // POST: NhaXBs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TenNhaXB,MaNhaXB,DiaChi")] NhaXB nhaXB)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhaXB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhaXB);
        }

        // GET: NhaXBs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaXB nhaXB = db.NhaXBs.Find(id);
            if (nhaXB == null)
            {
                return HttpNotFound();
            }
            return View(nhaXB);
        }

        // POST: NhaXBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NhaXB nhaXB = db.NhaXBs.Find(id);
            db.NhaXBs.Remove(nhaXB);
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
