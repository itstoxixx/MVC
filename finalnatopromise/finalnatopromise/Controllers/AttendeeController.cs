using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using finalnatopromise.Models;
using finalnatopromise.DAL;

namespace finalnatopromise.Controllers
{
    public class AttendeeController : Controller
    {
        private PoresContext db = new PoresContext();

        // GET: /Attendee/
        public ActionResult Index()
        {
            var attendees = db.Attendees.Include(a => a.Seminar);
            return View(attendees.ToList());
        }

        // GET: /Attendee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Attendee attendee = db.Attendees.Find(id);
            if (attendee == null)
            {
                return HttpNotFound();
            }
            return View(attendee);
        }

        // GET: /Attendee/Create
        public ActionResult Create()
        {
            ViewBag.SeminarID = new SelectList(db.Seminars, "SeminarID", "Title");
            return View();
        }

        // POST: /Attendee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Name,Gender,RegistrationDate,SeminarID")] Attendee attendee)
        {
            if (ModelState.IsValid)
            {
                db.Attendees.Add(attendee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SeminarID = new SelectList(db.Seminars, "SeminarID", "Title", attendee.SeminarID);
            return View(attendee);
        }

        // GET: /Attendee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Attendee attendee = db.Attendees.Find(id);
            if (attendee == null)
            {
                return HttpNotFound();
            }
            ViewBag.SeminarID = new SelectList(db.Seminars, "SeminarID", "Title", attendee.SeminarID);
            return View(attendee);
        }

        // POST: /Attendee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Name,Gender,RegistrationDate,SeminarID")] Attendee attendee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attendee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SeminarID = new SelectList(db.Seminars, "SeminarID", "Title", attendee.SeminarID);
            return View(attendee);
        }

        // GET: /Attendee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Attendee attendee = db.Attendees.Find(id);
            if (attendee == null)
            {
                return HttpNotFound();
            }
            return View(attendee);
        }

        // POST: /Attendee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Attendee attendee = db.Attendees.Find(id);
            db.Attendees.Remove(attendee);
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
