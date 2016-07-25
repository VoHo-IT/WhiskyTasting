using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WhiskyTasting.Models;

namespace WhiskyTasting.Controllers
{
    public class WhiskysController : Controller
    {
        private WhiskyDbContext db = new WhiskyDbContext();

        // GET: Whiskys
        public ActionResult Index()
        {
            return View(db.Whiskys.ToList());
        }

        // GET: Whiskys/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Whisky whisky = db.Whiskys.Find(id);
            if (whisky == null)
            {
                return HttpNotFound();
            }
            return View(whisky);
        }

        // GET: Whiskys/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Whiskys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Age,Distillery,Price")] Whisky whisky)
        {
            if (ModelState.IsValid)
            {
                db.Whiskys.Add(whisky);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(whisky);
        }

        // GET: Whiskys/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Whisky whisky = db.Whiskys.Find(id);
            if (whisky == null)
            {
                return HttpNotFound();
            }
            return View(whisky);
        }

        // POST: Whiskys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Age,Distillery,Price")] Whisky whisky)
        {
            if (ModelState.IsValid)
            {
                db.Entry(whisky).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(whisky);
        }

        // GET: Whiskys/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Whisky whisky = db.Whiskys.Find(id);
            if (whisky == null)
            {
                return HttpNotFound();
            }
            return View(whisky);
        }

        // POST: Whiskys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Whisky whisky = db.Whiskys.Find(id);
            db.Whiskys.Remove(whisky);
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
