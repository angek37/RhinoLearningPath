using System;
using System.ComponentModel.DataAnnotations;
using ModelValidation.Infrastructure;
using System.Web.Mvc;

namespace ModelValidation.Models
{
    [NoJoeOnMondays]
    public class Appointment
    {
        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string ClientName { set; get; }
        [DataType(DataType.Date)]
        //[Required(ErrorMessage = "Please enter a date")]
        // Custom Model Validation Attribute 
        //[FutureDate(ErrorMessage = "Please enter a date in the future")]
        [Remote("ValidateDate", "Home")]
        public DateTime Date { set; get; }
        //[Range(typeof(bool), "true", "true", ErrorMessage = "You must accept the terms")]
        // Custom Validation Attribute
        [MustBeTrue(ErrorMessage = "You must accept the terms")]
        public bool TermsAccepted { set; get; }
    }
}