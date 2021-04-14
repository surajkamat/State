using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StateScholarship.Models
{
    [Table("RegisterTb")]
    public class UserRegistration
    {
        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        [Display(Name = "Contact Number")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Please enter valid contact number")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        [Display(Name = "User Category")]
        public string UserCategory { get; set; }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}