﻿using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { set; get; }
        public string ReturnUrl { set; get; }
    }
}