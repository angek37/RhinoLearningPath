using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { set; get; }
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string Email { set; get; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { set; get; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { set; get; }
    }
}