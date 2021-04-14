using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StateScholarship.Models
{
    
    public class LoginView
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        [Display(Name = "User Category")]
        public string UserCategory { get; set; }

    }
}