using MVC5Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Demo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Create(int departmentId)
        {
            var employee = new Employee();
            employee.Department_Id = departmentId;
            return View(employee);
        }

        MVC5DemoDatabaseEntities _db = new MVC5DemoDatabaseEntities();

        [HttpPost]
        public ActionResult Create(Employee employee1)
        {
            if (ModelState.IsValid)
            {
                var department = _db.Departments.Single(d => d.Id == employee1.Department_Id);
                department.Employees.Add(employee1);
                _db.SaveChanges();
                return RedirectToAction("Details", "Home", new { id = employee1.Department_Id });
            }

            return View(employee1);
        }
    }
}