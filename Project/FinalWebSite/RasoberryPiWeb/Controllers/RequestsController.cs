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
    public class RequestsController : Controller
    {
        private WebsiteDatabaseProjectEntities db = new WebsiteDatabaseProjectEntities();

        // GET: Requests
        public ActionResult Index()
        {
            var requests = db.Requests.Include(r => r.Citizen).Include(r => r.Mostanadat).Include(r => r.Msale7);
            return View(requests.ToList());
        }

        // GET: Requests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = db.Requests.Find(id);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        // GET: Requests/Create
        public ActionResult Create()
        {
            ViewBag.Citizen_ID = new SelectList(db.Citizens, "National_ID", "Citizen_Name");
            ViewBag.Mostanad_ID = new SelectList(db.Mostanadats, "Mostanad_ID", "Mostanad_Name");
            ViewBag.Msl7a_ID = new SelectList(db.Msale7, "Msl7a_ID", "Msl7a_Name");
            return View();
        }

        // POST: Requests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Request_ID,Msl7a_ID,Mostanad_ID,No_of_copies,Citizen_ID,Printed_or_not,toPrint")] Request request)
        {
            if (ModelState.IsValid)
            {
                db.Requests.Add(request);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Citizen_ID = new SelectList(db.Citizens, "National_ID", "Citizen_Name", request.Citizen_ID);
            ViewBag.Mostanad_ID = new SelectList(db.Mostanadats, "Mostanad_ID", "Mostanad_Name", request.Mostanad_ID);
            ViewBag.Msl7a_ID = new SelectList(db.Msale7, "Msl7a_ID", "Msl7a_Name", request.Msl7a_ID);
            return View(request);
        }

        // GET: Requests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = db.Requests.Find(id);
            if (request == null)
            {
                return HttpNotFound();
            }
            ViewBag.Citizen_ID = new SelectList(db.Citizens, "National_ID", "Citizen_Name", request.Citizen_ID);
            ViewBag.Mostanad_ID = new SelectList(db.Mostanadats, "Mostanad_ID", "Mostanad_Name", request.Mostanad_ID);
            ViewBag.Msl7a_ID = new SelectList(db.Msale7, "Msl7a_ID", "Msl7a_Name", request.Msl7a_ID);
            return View(request);
        }

        // POST: Requests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Request_ID,Msl7a_ID,Mostanad_ID,No_of_copies,Citizen_ID,Printed_or_not,toPrint")] Request request)
        {
            if (ModelState.IsValid)
            {
                db.Entry(request).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Citizen_ID = new SelectList(db.Citizens, "National_ID", "Citizen_Name", request.Citizen_ID);
            ViewBag.Mostanad_ID = new SelectList(db.Mostanadats, "Mostanad_ID", "Mostanad_Name", request.Mostanad_ID);
            ViewBag.Msl7a_ID = new SelectList(db.Msale7, "Msl7a_ID", "Msl7a_Name", request.Msl7a_ID);
            return View(request);
        }

        // GET: Requests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = db.Requests.Find(id);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        // POST: Requests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Request request = db.Requests.Find(id);
            db.Requests.Remove(request);
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
