﻿using System;

namespace SportsStore.WebUI.Models
{
    public class PagingInfo
    {
        public int TotalItems { set; get; }
        public int ItemsPerPage { set; get; }
        public int CurrentPage { set; get; }

        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}