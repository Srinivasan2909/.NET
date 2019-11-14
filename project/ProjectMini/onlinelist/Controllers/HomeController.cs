using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using onlinelist.Models;
using onlinelist.Controllers;
using System.Web.Security;

namespace onlinelist.Controllers
{
    
    public class HomeController : Controller
    {
        miniprojectEntities entities = new miniprojectEntities();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginDetail user)

        {
            //user.confirmPassword = user.password;
            //if (ModelState.IsValid)
            //{
            bool isValidUser = entities.LoginDetails.Any
                (u => u.username == user.username && u.password == user.password);
            if (isValidUser)
            {
                System.Web.Security.FormsAuthentication.SetAuthCookie(user.username, false);
                LoginDetail selectedUser = entities.LoginDetails.FirstOrDefault(x => x.username == user.username);

                return RedirectToAction("UserProfile", new { selectedUser.Id });
            }
            //}

            ModelState.AddModelError("", "Invalid username or password");
            return View();


        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(commonModel commonModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    entities.LoginDetails.Add(commonModel.LoginDetail);
                    commonModel.UserDetail.LoginID = commonModel.LoginDetail.Id;
                    entities.UserDetails.Add(commonModel.UserDetail);

                    entities.SaveChanges();
                    //TempData["abc"] = registeruser.Id;
                    return RedirectToAction("Login");
                }

            }

            catch (Exception es)
            {
                string innerex = es.InnerException.ToString();
                if (innerex.Contains("Cannot insert duplicate key in object 'dbo.LoginDetails'"))
                {
                    ViewBag.msg = "User Name already Exist!  Enter different User Name";
                    return View();
                }
                if (innerex.Contains("Cannot insert duplicate key in object 'dbo.UserDetails'"))
                {
                    ViewBag.msg = "Email Id OR Phone No already Used!  Enter different Email Id OR Phone No";
                    return View();
                }
            }


            return View();
        }







        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }


        public ActionResult UserProfile(int Id)
        {



            UserDetail selectedUser = entities.UserDetails.FirstOrDefault(x => x.LoginID == Id);

            return View(selectedUser);
        }
        public ActionResult Index(string search)
        {
            //cart c = new cart();
            //c.user_id = id;
            var books = from x in entities.booklists select x;
            if (!String.IsNullOrEmpty(search))
            {
                books = books.Where(s => s.book_name.Contains(search) | s.author_name.Contains(search));
            }
            return View(books);
        }
        
        public ActionResult Index2()
        {
            ViewBag.genre = new SelectList(entities.genres.ToList(), "genre_id", "genre_name");
            return View();
        }
        [HttpPost]
        public ActionResult Index2(FormCollection form)
        {
            TempData["abc"] = form[0];
            return RedirectToAction("Display");
        }
        public ActionResult Display()
        {
            int b = Convert.ToInt32(TempData["abc"]);
            List<booklist> selectedgenre = entities.booklists.Where(x => x.genre_id == b).ToList();

            return View(selectedgenre);
        }
        [HttpPost]
        public ActionResult Display(int[] def)
        {
            //TempData["qwe"] = form1["def"];
            miniprojectEntities entities = new miniprojectEntities();
            //booklist result = new booklist();
            //result.selectedbook = def;
            ////return RedirectToAction("Displayfinal");
            //IEnumerable<int> y = result.selectedbook;
            ////List<booklist> selbooks;
            cart order = new cart();
            booklist temp = new booklist();
             foreach (int item in def)
            {
                temp = entities.booklists.FirstOrDefault(x=>x.book_id == item);
                order.book_id = temp.book_id;
                order.book_name = temp.book_name;
                order.author_name = temp.author_name;
                order.price = temp.price;
                order.genre_id = temp.genre_id;
               // order.user_id=
                entities.carts.Add(order);
                entities.SaveChanges();

            }

            return RedirectToAction("Displayfinal");

        }

        public ActionResult Displayfinal()
        {
            //include user id
            miniprojectEntities entities = new miniprojectEntities();
            return View(entities.carts.ToList());
        }
        //public ActionResult Displayfinal(booklist result)
        //{

        //    //object c;
        //    //object c = (TempData["qwe"]);
        //    //(int)c = TempData["qwe"];
        //    miniprojectEntities entities = new miniprojectEntities();

        //    IEnumerable<int> y = result.selectedbook;
        //    //List<booklist> selbooks;
        //    var selbooks = from a in entities.booklists select a;
        //    foreach (int item in y)
        //    {
        //         selbooks = selbooks.Where(x => x.book_id == item);

        //    }
            
        //    return View(selbooks);
        //}



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}