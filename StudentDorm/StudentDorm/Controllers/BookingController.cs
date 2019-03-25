using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentDorm.Models;

namespace BookingStudentDorm.Controllers
{
    public class BookingController : Controller
    {
        private StudentDormContext db = new StudentDormContext();

        // GET: Booking
        public ActionResult Index()
        {
            return View(db.Booking.ToList());
        }

        // GET: Booking/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking booking = db.Booking.Find(id);
            if (booking == null)
            {
                return HttpNotFound();
            }
            return View(booking);
        }

        // GET: Booking/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Booking/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RoomID,StartDate,EndDate,UsedPlaces,Gender")] Booking booking)
        {
            if (!ModelState.IsValid)
            {


                return View(booking);
            }

            if (booking.StartDate < DateTime.Today)
            {
                ModelState.AddModelError("StartDate", "Start Date must start not early today!");
                return View(booking);
            }

            if (booking.EndDate <= booking.StartDate)
            {
                ModelState.AddModelError("EndDate", "End Date must be after the Start Date!");
                return View(booking);
            }
            int roomID = booking.RoomID;

            //during period a to b -- dorm is busy
            // error when: (a <=start <= b) or (a <= end <= b) or (start<= a & b <= end)
            var result = db.Booking.Where(p => p.RoomID == roomID && 
                ((p.StartDate <= booking.StartDate && booking.StartDate <= p.EndDate) ||
                (p.StartDate <= booking.EndDate && booking.EndDate <= p.EndDate) ||
                (booking.StartDate <= p.StartDate && p.EndDate <= booking.StartDate)));
            int count = result.Count();
            if (count > 0)
            {
                ModelState.AddModelError("StartDate", "In selected period Student dorm is busy!");
                return View(booking);
            }

            db.Booking.Add(booking);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        // GET: Booking/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking booking = db.Booking.Find(id);
            if (booking == null)
            {
                return HttpNotFound();
            }
            return View(booking);
        }

        // POST: Booking/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Booking booking = db.Booking.Find(id);
            db.Booking.Remove(booking);
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
