using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Demo.Models;

namespace MVC5Demo.Controllers
{
    public class HomeController : Controller
    {
        MVC5DemoDatabaseEntities db = new MVC5DemoDatabaseEntities();

        public ActionResult Index()
        {
            var alldepartment = db.Departments;
            return View(alldepartment);
        }

        public ActionResult About()
        {
            var model = new Person() { Name = "Sean" };

            ViewBag.Message = "Your application description page.";
            ViewBag.Location = "Seoul, Korea";
            ViewBag.Name = "Sean You";
            ViewBag.Age = 39;

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details(int id)
        {
            var selectedDepartment = db.Departments.Single(d => d.Id == id);

            return View(selectedDepartment);
        }

        public ActionResult Create()
        {
            return View(new Department());
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            db.Departments.Add(department);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}