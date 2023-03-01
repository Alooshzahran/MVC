using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using task_12_2;

namespace task_12_2.Controllers
{
    public class Student_CoursesController : Controller
    {
        private MVCEntities db = new MVCEntities();

        // GET: Student_Courses
        public ActionResult Index()
        {
            var student_Courses = db.Student_Courses.Include(s => s.Cours).Include(s => s.Student);
            return View(student_Courses.ToList());
        }

        // GET: Student_Courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Courses student_Courses = db.Student_Courses.Find(id);
            if (student_Courses == null)
            {
                return HttpNotFound();
            }
            return View(student_Courses);
        }

        // GET: Student_Courses/Create
        public ActionResult Create()
        {
            ViewBag.Fk_Course = new SelectList(db.Courses, "IdCourse", "CourseName");
            ViewBag.FK_Student = new SelectList(db.Students, "IdStudent", "StudentName");
            return View();
        }

        // POST: Student_Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FK_Student,Fk_Course,note,id")] Student_Courses student_Courses)
        {
            if (ModelState.IsValid)
            {
                db.Student_Courses.Add(student_Courses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Fk_Course = new SelectList(db.Courses, "IdCourse", "CourseName", student_Courses.Fk_Course);
            ViewBag.FK_Student = new SelectList(db.Students, "IdStudent", "StudentName", student_Courses.FK_Student);
            return View(student_Courses);
        }

        // GET: Student_Courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Courses student_Courses = db.Student_Courses.Find(id);
            if (student_Courses == null)
            {
                return HttpNotFound();
            }
            ViewBag.Fk_Course = new SelectList(db.Courses, "IdCourse", "CourseName", student_Courses.Fk_Course);
            ViewBag.FK_Student = new SelectList(db.Students, "IdStudent", "StudentName", student_Courses.FK_Student);
            return View(student_Courses);
        }

        // POST: Student_Courses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FK_Student,Fk_Course,note,id")] Student_Courses student_Courses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student_Courses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Fk_Course = new SelectList(db.Courses, "IdCourse", "CourseName", student_Courses.Fk_Course);
            ViewBag.FK_Student = new SelectList(db.Students, "IdStudent", "StudentName", student_Courses.FK_Student);
            return View(student_Courses);
        }

        // GET: Student_Courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Courses student_Courses = db.Student_Courses.Find(id);
            if (student_Courses == null)
            {
                return HttpNotFound();
            }
            return View(student_Courses);
        }

        // POST: Student_Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student_Courses student_Courses = db.Student_Courses.Find(id);
            db.Student_Courses.Remove(student_Courses);
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
