using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalWebSite.Models;

namespace FinalWebSite.Controllers
{
    public class MostanadatsController : Controller
    {
        private WebsiteDatabaseProjectEntities2 db = new WebsiteDatabaseProjectEntities2();

        // GET: Mostanadats
        public ActionResult Index()
        {
            var mostanadats = db.Mostanadats.Include(m => m.Msale7);
            return View(mostanadats.ToList());
        }

        // GET: Mostanadats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mostanadat mostanadat = db.Mostanadats.Find(id);
            if (mostanadat == null)
            {
                return HttpNotFound();
            }
            return View(mostanadat);
        }

        // GET: Mostanadats/Create
        public ActionResult Create()
        {
            ViewBag.Msl7a_ID = new SelectList(db.Msale7, "Msl7a_ID", "Msl7a_Name");
            return View();
        }

        // POST: Mostanadats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Mostanad_ID,Mostanad_Name,Msl7a_ID")] Mostanadat mostanadat)
        {
            if (ModelState.IsValid)
            {
                db.Mostanadats.Add(mostanadat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Msl7a_ID = new SelectList(db.Msale7, "Msl7a_ID", "Msl7a_Name", mostanadat.Msl7a_ID);
            return View(mostanadat);
        }

        // GET: Mostanadats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mostanadat mostanadat = db.Mostanadats.Find(id);
            if (mostanadat == null)
            {
                return HttpNotFound();
            }
            ViewBag.Msl7a_ID = new SelectList(db.Msale7, "Msl7a_ID", "Msl7a_Name", mostanadat.Msl7a_ID);
            return View(mostanadat);
        }

        // POST: Mostanadats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Mostanad_ID,Mostanad_Name,Msl7a_ID")] Mostanadat mostanadat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mostanadat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Msl7a_ID = new SelectList(db.Msale7, "Msl7a_ID", "Msl7a_Name", mostanadat.Msl7a_ID);
            return View(mostanadat);
        }

        // GET: Mostanadats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mostanadat mostanadat = db.Mostanadats.Find(id);
            if (mostanadat == null)
            {
                return HttpNotFound();
            }
            return View(mostanadat);
        }

        // POST: Mostanadats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mostanadat mostanadat = db.Mostanadats.Find(id);
            db.Mostanadats.Remove(mostanadat);
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
