using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using depandemp.Models;

namespace depandemp.Controllers
{
    public class HomeController : Controller
    {
        joinEntities entities = new joinEntities();
        
        // GET: Home
        public ActionResult Index()
        {
            return View(entities.employees.ToList());
        }
        public ActionResult Index1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index1(int id)
        {
            TempData["abc"] = id;
            return RedirectToAction("Display");
        }
        public ActionResult Display()
        {
            int id = Convert.ToInt32(TempData["abc"]);
            List<employee> searchedid = entities.employees.Where(x => x.department_id == id).ToList();
            return View(searchedid);
        }
    }
}