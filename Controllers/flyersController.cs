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
    public class flyersController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: flyers
        public ActionResult Index()
        {
            return View(db.Flyers.ToList());
        }

        // GET: flyers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            flyers flyers = db.Flyers.Find(id);
            if (flyers == null)
            {
                return HttpNotFound();
            }
            return View(flyers);
        }

        // GET: flyers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: flyers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "flyerID,flyerFirstName,flyerLastName,email")] flyers flyers)
        {
            if (ModelState.IsValid)
            {
                db.Flyers.Add(flyers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(flyers);
        }

        // GET: flyers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            flyers flyers = db.Flyers.Find(id);
            if (flyers == null)
            {
                return HttpNotFound();
            }
            return View(flyers);
        }

        // POST: flyers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "flyerID,flyerFirstName,flyerLastName,email")] flyers flyers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(flyers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(flyers);
        }

        // GET: flyers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            flyers flyers = db.Flyers.Find(id);
            if (flyers == null)
            {
                return HttpNotFound();
            }
            return View(flyers);
        }

        // POST: flyers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            flyers flyers = db.Flyers.Find(id);
            db.Flyers.Remove(flyers);
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
