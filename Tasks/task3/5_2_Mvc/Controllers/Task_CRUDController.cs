using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using _5_2_Mvc;

namespace _5_2_Mvc.Controllers
{
   
    
    public class Task_CRUDController : Controller
    {
                //MVCEntities db = new MVCEntities();

       
        private MVCEntities db = new MVCEntities();

        // GET: Task_CRUD
        public ActionResult Index(string name)
        {
            return View(db.Task_CRUD.Where(s => s.farst_Name.Contains(name) || name==null).ToList());
        }

       
        

        // GET: Task_CRUD/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task_CRUD task_CRUD = db.Task_CRUD.Find(id);
            if (task_CRUD == null)
            {
                return HttpNotFound();
            }
            return View(task_CRUD);
        }

        // GET: Task_CRUD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Task_CRUD/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,farst_Name,Last_Name,Email,Phone,Age,Job_Title,Gender")] Task_CRUD task_CRUD)
        {
            if (ModelState.IsValid)
            {
                db.Task_CRUD.Add(task_CRUD);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(task_CRUD);
        }

        // GET: Task_CRUD/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task_CRUD task_CRUD = db.Task_CRUD.Find(id);
            if (task_CRUD == null)
            {
                return HttpNotFound();
            }
            return View(task_CRUD);
        }

        // POST: Task_CRUD/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,farst_Name,Last_Name,Email,Phone,Age,Job_Title,Gender")] Task_CRUD task_CRUD)
        {
            if (ModelState.IsValid)
            {
                db.Entry(task_CRUD).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(task_CRUD);
        }

        // GET: Task_CRUD/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task_CRUD task_CRUD = db.Task_CRUD.Find(id);
            if (task_CRUD == null)
            {
                return HttpNotFound();
            }
            return View(task_CRUD);
        }

        // POST: Task_CRUD/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Task_CRUD task_CRUD = db.Task_CRUD.Find(id);
            db.Task_CRUD.Remove(task_CRUD);
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
