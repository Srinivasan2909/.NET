using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dropdown.Models;

namespace dropdown.Controllers
{
    public class dropController : Controller
    {
        // GET: drop
        public ActionResult Index()
        {
            assingmentEntities obj = new assingmentEntities();
            ViewBag.Countries = new SelectList(GetCountries(), "CountryID", "CountryName");
            return View();
        }
        public List<country>GetCountries()
        {
            assingmentEntities obj = new assingmentEntities();
            List<country> countries = obj.countries.ToList();
            return countries;
        }
        public ActionResult GetStates(int CountryID)
        {
            assingmentEntities obj = new assingmentEntities();
            List<state> states1 = obj.states.Where(x => x.countryid == CountryID).ToList();
            ViewBag.abcd = new SelectList(states1, "stateid", "statename");
            return PartialView("DisplayStates");
        }
    }
}