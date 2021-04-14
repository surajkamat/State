using StateScholarship.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateScholarship.Controllers
{
    public class HomeController : Controller
    {
        DBHandler db;

        public ActionResult Index()
        {
            return View();
        }

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

        [HttpGet]
        public ActionResult AddUSer()
        {
            //This CategoryViewModel use for DropdownList for User Category
            CategoryViewModel viewmodel = new CategoryViewModel();
            ViewBag.Data = (from x in viewmodel.UserCategory select x.Value).Distinct();

            //This GenderViewModel use for DropdownList for User Gender
            GenderViewModel genderViewModel = new GenderViewModel();
            ViewBag.Data1 = (from y in genderViewModel.Gender select y.Value).Distinct();

            return View();
        }

        [HttpPost]
        public ActionResult AddUSer(UserRegistration model)
        {
            CategoryViewModel viewmodel = new CategoryViewModel();
            ViewBag.Data = (from x in viewmodel.UserCategory select x.Value).Distinct();

            GenderViewModel genderViewModel = new GenderViewModel();
            ViewBag.Data1 = (from y in genderViewModel.Gender select y.Value).Distinct();


            if (ModelState.IsValid)
            {
                using (db = new DBHandler())
                {
                    if ((db.UserRegistrations.Any(x => x.UserId == model.UserId)))
                    {
                        ViewBag.DuplicateMessage = "User Exist..Please enter unique Id";
                        return View("AddUSer", model);

                    }

                    db.UserRegistrations.Add(model);
                    db.SaveChanges();

                }

                ModelState.Clear();
                ViewBag.SuccessMessage = "User registration completed";

                return View("AddUser", new UserRegistration());
            }

            return View();
        }


        

    }
}