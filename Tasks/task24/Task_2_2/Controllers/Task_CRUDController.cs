using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Task_2_2;

namespace Task_2_2.Controllers
{
    public class Task_CRUDController : Controller
    {
        private MVCEntities1 db = new MVCEntities1();

        // GET: Task_CRUD
        public ActionResult Index(string searchString, string searchBy)
        {

            var task = from t in db.Task_CRUD select t;

            if (!String.IsNullOrEmpty(searchString))
            {
                switch (searchBy)
                {
                    case "First Name":
                        task =  task.Where(s => s.farst_Name.Contains(searchString));
                        break;
                    case "Last Name":
                        task = task.Where(s => s.Last_Name.Contains(searchString));
                        break;
                    case "Email":
                        task = task.Where(s => s.Email.Contains(searchString));
                        break;
                    default:
                        task = task.Where(s => s.farst_Name.Contains(searchString) || s.Last_Name.Contains(searchString) || s.Job_Title.Contains(searchString) || s.Age.ToString().Equals(searchString));
                        break;
                }
            }
            if (task.ToList().Count <= 0 || searchString == "")
            {
                ViewBag.SearchString = "Not Found";
            }
            return View(task.ToList());
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
        public ActionResult Create(Task_CRUD task_CRUD, HttpPostedFileBase image, HttpPostedFileBase CV)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    //string fileName = Path.GetFileName(image.FileName);
                    string path = Server.MapPath("~/image/") + image.FileName;
                    image.SaveAs(path);
                    task_CRUD.image = image.FileName;
                }

                if (CV != null)
                {
                    //string fileName = Path.GetFileName(cv.FileName);
                    string path = Server.MapPath("~/CV/") + CV.FileName;
                    CV.SaveAs(path);
                    task_CRUD.CV = CV.FileName;
                }
                db.Task_CRUD.Add(task_CRUD);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(task_CRUD);
        }


        public FileResult Download(string CV)
        {
            string name = "../CV/" + CV;
            string path = Server.MapPath(name);
            byte[] fileBytes = System.IO.File.ReadAllBytes(path);
            return File(fileBytes, "application.pdf", CV);

        }



        // GET: Task_CRUD/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task_CRUD task_CRUD = db.Task_CRUD.Find(id);
            Session["image"] = task_CRUD.image;
            Session["cv"] = task_CRUD.CV;
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
        public ActionResult Edit(Task_CRUD task_CRUD, HttpPostedFileBase image, HttpPostedFileBase CV)
        {
            task_CRUD.image = Session["image"].ToString();
            task_CRUD.CV = Session["cv"].ToString();
            if (ModelState.IsValid)
            {

                if (image != null)
                {
                    //string fileName = Path.GetFileName(image.FileName);
                    string path = Server.MapPath("~/image/") + image.FileName;
                    image.SaveAs(path);
                    task_CRUD.image = image.FileName;
                }


                if (CV != null)
                {
                    //string fileName = Path.GetFileName(cv.FileName);
                    string path = Server.MapPath("~/CV/") + CV.FileName;
                    CV.SaveAs(path);
                    task_CRUD.CV = ViewBag.cv;
                }



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
