using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmpManagement;

namespace EmpManagement.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeesManagementEntities db = new EmployeesManagementEntities();

        // GET: Employees
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            var items = db.Departments.ToList().FindAll(x => x.IsActive == true);
            if (items != null)
            {
                ViewBag.data = items;
            }
            return View();
        }
       

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EMPID,FirstName,LastName,Email,PhoneNumber,Salary,ImageName,DepID,IsActive")] Employee employee, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    if (file != null && file.ContentLength > 0)
                    {
                        //employee.ImageName = Path.GetFileName(file.FileName);
                        employee.ImageName = string.Format("{0:yyyyMMddhhmmss}.png", DateTime.Now);
                        string _path = Path.Combine(Server.MapPath("~/UploadFiles"), employee.ImageName);
                        file.SaveAs(_path);
                    }
                    ViewBag.Message = "File Uploaded Successfully!!";
                   
                }
                catch
                {
                    ViewBag.Message = "File upload failed!!";
                    return View();
                }

                employee.DepID = Convert.ToInt32(Request.Form["DepartmentName"]);
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            var items = db.Departments.ToList().FindAll(x => x.IsActive == true);
            if (items != null)
            {
                ViewBag.data = items;
            }
            if (employee == null)
            {
                return HttpNotFound();
            }
            if (employee.ImageName != null)
            {
                employee.ImageName = Path.Combine(Server.MapPath("~/UploadFiles"), employee.ImageName);
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EMPID,FirstName,LastName,Email,PhoneNumber,Salary,ImageName,DepID,IsActive")] Employee employee, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (file != null && file.ContentLength > 0)
                    {
                        //employee.ImageName = Path.GetFileName(file.FileName);
                        employee.ImageName = string.Format("{0:yyyyMMddhhmmss}.png", DateTime.Now);
                        string _path = Path.Combine(Server.MapPath("~/UploadFiles"), employee.ImageName);
                        file.SaveAs(_path);
                    }
                    ViewBag.Message = "File Uploaded Successfully!!";

                }
                catch
                {
                    ViewBag.Message = "File upload failed!!";
                    return View();
                }
                employee.DepID = Convert.ToInt32(Request.Form["DepartmentName"]);
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
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
