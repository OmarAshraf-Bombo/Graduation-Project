using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RasoberryPiWeb.Models;

namespace RasoberryPiWeb.Controllers
{
    public class CitizensController : Controller
    {
        private WebsiteDatabaseProjectEntities db = new WebsiteDatabaseProjectEntities();

        // GET: Citizens
        public ActionResult Index()
        {
            return View(db.Citizens.ToList());
        }

        // GET: Citizens/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Citizen citizen = db.Citizens.Find(id);
            if (citizen == null)
            {
                return HttpNotFound();
            }
            return View(citizen);
        }

        // GET: Citizens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Citizens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "National_ID,Citizen_Name,Password,BirthDate,Relegion,Mother_Name,M7l_elmelad,Nationality")] Citizen citizen)
        {
            if (ModelState.IsValid)
            {
                db.Citizens.Add(citizen);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(citizen);
        }

        // GET: Citizens/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Citizen citizen = db.Citizens.Find(id);
            if (citizen == null)
            {
                return HttpNotFound();
            }
            return View(citizen);
        }

        // POST: Citizens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "National_ID,Citizen_Name,Password,BirthDate,Relegion,Mother_Name,M7l_elmelad,Nationality")] Citizen citizen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(citizen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(citizen);
        }

        // GET: Citizens/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Citizen citizen = db.Citizens.Find(id);
            if (citizen == null)
            {
                return HttpNotFound();
            }
            return View(citizen);
        }

        // POST: Citizens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Citizen citizen = db.Citizens.Find(id);
            db.Citizens.Remove(citizen);
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
