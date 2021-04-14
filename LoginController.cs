using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StateScholarship.Models;

namespace StateScholarship.Controllers
{
    public class LoginController : Controller
    {

        DBHandler db = new DBHandler();
        // GET: Login

        [HttpGet]
        public ActionResult login()
        {
            UserType user = new UserType();
            LoginView LoginView = new LoginView();
            ViewBag.Data = (from z in user.UserTypes select z.Value).Distinct();

            return View(LoginView);
        }


        [HttpPost]
        public ActionResult login(LoginView loginmodel)
        {
            UserType user = new UserType();
            LoginView LoginView = new LoginView();

            ViewBag.Data = (from z in user.UserTypes select z.Value).Distinct();

            if (ModelState.IsValid)
            {
                using (db = new DBHandler())
                {
                    var checkUSer = db.UserRegistrations.Where(d => d.UserId == loginmodel.UserId && d.Password == loginmodel.Password && d.UserCategory == loginmodel.UserCategory).FirstOrDefault();

                    //r checkAdminUSer = db.UserRegistrations.Where(d => d.UserId == loginmodel.UserId && d.Password == loginmodel.Password && d.UserCategory == loginmodel.UserCategory).FirstOrDefault();


                    if (checkUSer != null)
                    {
                        if (loginmodel.UserCategory == "Scholarship Provider")
                        {
                            return View("ScholarshipProvider");
                        }

                        else if (loginmodel.UserCategory == "Admin")
                        {
                            return View("Admin");
                        }

                        else
                        {
                            return View("Student");
                        }
                    }

                   

                    else
                    {
                        ModelState.Clear();
                        ViewBag.RejectMessage = "Invalid user Id or Password";
                        return View("login");
                    }



                }

            }
            return View();

        }

    }
}