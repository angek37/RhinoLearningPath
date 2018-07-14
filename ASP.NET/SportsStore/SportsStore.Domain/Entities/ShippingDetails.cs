﻿using System.ComponentModel.DataAnnotations;

namespace SportsStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { set; get; }

        [Required(ErrorMessage = "Please enter the first address line")]
        public string Line1 { set; get; }
        public string Line2 { set; get; }
        public string Line3 { set; get; }

        [Required(ErrorMessage = "Please enter a city name")]
        public string City { set; get; }

        [Required(ErrorMessage = "Please enter a state name")]
        public string State { set; get; }

        public string Zip { set; get; }

        [Required(ErrorMessage = "Please enter a country name")]
        public string Country { set; get; }

        public bool GiftWrap { set; get; }
    }
}
