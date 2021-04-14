using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateScholarship.Models
{
    public class GenderViewModel
    {

        public UserRegistration UserRegistration { get; set; }

        public IEnumerable<SelectListItem> Gender
        {

            get
            {
                return new List<SelectListItem>()
                {
                    new SelectListItem{Text="Male", Value="Male" },
                    new SelectListItem{Text="Female", Value="Female" },
                    new SelectListItem{Text="Other", Value="Other"}

                };
            }

            set
            {

            }

        }
    }
}