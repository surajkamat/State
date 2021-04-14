using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; //SelectListItem

namespace StateScholarship.Models
{
    public class CategoryViewModel
    {
        public UserRegistration UserRegistration { get; set; }

        public IEnumerable<SelectListItem> UserCategory
        {

            get
            {
                return new List<SelectListItem>()
                {
                    new SelectListItem{Text="Student", Value="Student" },
                    new SelectListItem{Text="Scholarship Provider", Value="Scholarship Provider"}

                };
            }

            set
            {

            }

        }

    }
}