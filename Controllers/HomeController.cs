using DatabaseFirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseFirstApp.Controllers
{
    public class HomeController : Controller
    {
        empDBContext db = new empDBContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var data = db.EmployeeTables.ToList();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeTable eobj)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeTables.Add(eobj);
                int n = db.SaveChanges();
                if (n != 0)
                {
                    TempData["Insert"] = "<script>alert('Employee Addedd Successfully!!')</script>";
                }
                else
                {
                    TempData["Insert"] = "<script>alert('Employee Adding Failed!!')</script>";
                }
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            var data = db.EmployeeTables.Where(m => m.EmpId == id).FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeTable eobj)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eobj).State = EntityState.Modified;
                int n = db.SaveChanges();
                if (n != 0)
                {
                    TempData["update"] = "<script>alert('Employee updated Successfully!!')</script>";
                }
                else
                {
                    TempData["update"] = "<script>alert('Employee Adding Failed!!')</script>";
                }
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var data = db.EmployeeTables.Where(m => m.EmpId == id).FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(EmployeeTable eobj)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eobj).State = EntityState.Deleted;
                int n = db.SaveChanges();
                if (n != 0)
                {
                    TempData["delete"] = "<script>alert('Employee deleted Successfully!!')</script>";
                }
                else
                {
                    TempData["delete"] = "<script>alert('Employee deleting Failed!!')</script>";
                }
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            var data = db.EmployeeTables.Where(m => m.EmpId == id).FirstOrDefault();
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
