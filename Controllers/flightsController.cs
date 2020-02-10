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
    public class flightsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: flights
        public ActionResult Index()
        {
            var flights = db.Flights.Include(f => f.Airplanes).Include(f => f.Flyers);
            return View(flights.ToList());
        }

        // GET: flights/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            flights flights = db.Flights.Find(id);
            if (flights == null)
            {
                return HttpNotFound();
            }
            return View(flights);
        }

        // GET: flights/Create
        public ActionResult Create()
        {
            ViewBag.airplaneID = new SelectList(db.airplanes, "airplaneID", "airplaneName");
            ViewBag.flyerID = new SelectList(db.Flyers, "flyerID", "fullname");
            return View();
        }

        // POST: flights/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "flightID,flightName,destination,dateOfFlight,airplaneID,flyerID")] flights flights)
        {
            if (ModelState.IsValid)
            {
                db.Flights.Add(flights);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.airplaneID = new SelectList(db.airplanes, "airplaneID", "airplaneName", flights.airplaneID);
            ViewBag.flyerID = new SelectList(db.Flyers, "flyerID", "FullName", flights.flyerID);
            return View(flights);
        }

        // GET: flights/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            flights flights = db.Flights.Find(id);
            if (flights == null)
            {
                return HttpNotFound();
            }
            ViewBag.airplaneID = new SelectList(db.airplanes, "airplaneID", "airplaneName", flights.airplaneID);
            ViewBag.flyerID = new SelectList(db.Flyers, "flyerID", "FullName", flights.flyerID);
            return View(flights);
        }

        // POST: flights/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "flightID,flightName,destination,dateOfFlight,airplaneID,flyerID")] flights flights)
        {
            if (ModelState.IsValid)
            {
                db.Entry(flights).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.airplaneID = new SelectList(db.airplanes, "airplaneID", "airplaneName", flights.airplaneID);
            ViewBag.flyerID = new SelectList(db.Flyers, "flyerID", "flyerFirstName", flights.flyerID);
            return View(flights);
        }

        // GET: flights/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            flights flights = db.Flights.Find(id);
            if (flights == null)
            {
                return HttpNotFound();
            }
            return View(flights);
        }

        // POST: flights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            flights flights = db.Flights.Find(id);
            db.Flights.Remove(flights);
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
