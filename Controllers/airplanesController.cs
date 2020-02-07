using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using tk848615_MIS4200.DAL;
using tk848615_MIS4200.Models;

namespace tk848615_MIS4200.Controllers
{
    public class airplanesController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: airplanes
        public ActionResult Index()
        {
            return View(db.airplanes.ToList());
        }

        // GET: airplanes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            airplanes airplanes = db.airplanes.Find(id);
            if (airplanes == null)
            {
                return HttpNotFound();
            }
            return View(airplanes);
        }

        // GET: airplanes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: airplanes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "airplaneID,airplaneManufacturer,airplaneType,dateBuilt")] airplanes airplanes)
        {
            if (ModelState.IsValid)
            {
                db.airplanes.Add(airplanes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(airplanes);
        }

        // GET: airplanes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            airplanes airplanes = db.airplanes.Find(id);
            if (airplanes == null)
            {
                return HttpNotFound();
            }
            return View(airplanes);
        }

        // POST: airplanes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "airplaneID,airplaneManufacturer,airplaneType,dateBuilt")] airplanes airplanes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(airplanes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(airplanes);
        }

        // GET: airplanes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            airplanes airplanes = db.airplanes.Find(id);
            if (airplanes == null)
            {
                return HttpNotFound();
            }
            return View(airplanes);
        }

        // POST: airplanes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            airplanes airplanes = db.airplanes.Find(id);
            db.airplanes.Remove(airplanes);
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
