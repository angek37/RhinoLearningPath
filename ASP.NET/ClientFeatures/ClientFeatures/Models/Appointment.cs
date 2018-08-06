using System;
using System.ComponentModel.DataAnnotations;

namespace ClientFeatures.Models
{
    public class Appointment
    {
        [Required]
        public string ClientName { set; get; }
        public bool TermsAccepted { set; get; }
    }
}