using System.Collections.Generic;

namespace EssentialTools.Models
{
    public class ShoppingCart
    {
        private IValueCalculator calc;

        public ShoppingCart(IValueCalculator calcParam)
        {
            calc = calcParam;
        }

        public IEnumerable<Product> Products { set; get; }

        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}