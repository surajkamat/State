using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateScholarship.Models
{
    public class UserType
    {
        public LoginView LoginView { get; set; }

        public IEnumerable<SelectListItem> UserTypes
        {

            get
            {
                return new List<SelectListItem>()
                {

                    new SelectListItem{Text="Student", Value="Student" },
                    new SelectListItem{Text="Scholarship Provider", Value="Scholarship Provider"},
                    new SelectListItem{Text="Admin", Value="Admin" }


                };
            }

            set
            {

            }

        }

    }
}