using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public class Product
    {
        private string name;

        public int ProductID { set; get; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description { set; get; }
        public decimal Price { set; get; }
        public string Category { set; get; }
    }
}