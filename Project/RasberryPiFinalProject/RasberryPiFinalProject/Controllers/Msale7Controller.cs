using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RasberryPiFinalProject.Models;

namespace RasberryPiFinalProject.Controllers
{
    public class Msale7Controller : Controller
    {
        private WebsiteDatabaseProjectEntities2 db = new WebsiteDatabaseProjectEntities2();

        // GET: Msale7
        public ActionResult Index()
        {
            return View(db.Msale7.ToList());
        }

        // GET: Msale7/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Msale7 msale7 = db.Msale7.Find(id);
            if (msale7 == null)
            {
                return HttpNotFound();
            }
            return View(msale7);
        }

        // GET: Msale7/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Msale7/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Msl7a_ID,Msl7a_Name")] Msale7 msale7)
        {
            if (ModelState.IsValid)
            {
                db.Msale7.Add(msale7);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(msale7);
        }

        // GET: Msale7/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Msale7 msale7 = db.Msale7.Find(id);
            if (msale7 == null)
            {
                return HttpNotFound();
            }
            return View(msale7);
        }

        // POST: Msale7/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Msl7a_ID,Msl7a_Name")] Msale7 msale7)
        {
            if (ModelState.IsValid)
            {
                db.Entry(msale7).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(msale7);
        }

        // GET: Msale7/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Msale7 msale7 = db.Msale7.Find(id);
            if (msale7 == null)
            {
                return HttpNotFound();
            }
            return View(msale7);
        }

        // POST: Msale7/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Msale7 msale7 = db.Msale7.Find(id);
            db.Msale7.Remove(msale7);
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
