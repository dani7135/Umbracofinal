using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary
{
    public class Submisssion
    {
        public int Id { get; set; }

      //  [AgeServices(18, ErrorMessage = "{0} must be someone at least {1} years of age")]
        [Range(18,102, ErrorMessage = "Must be older than 18 to submit")]
        [Required]
        [DisplayName("Current age")]
        /*[DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Age { get; set; }*/
        public int Age { get; set; }
        [Required]
        [Display(Name = " First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = " Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        //  [Required]
        [Range(10000000, 99999999, ErrorMessage = "Enter vaild 8 digits serial number")]
        [Display(Name = "Valid product serial number")]
        public int SerialNumber { get; set; }
    }
}
