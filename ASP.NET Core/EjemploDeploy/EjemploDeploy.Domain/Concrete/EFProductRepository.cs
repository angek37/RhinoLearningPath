using System;
using System.Collections.Generic;
using System.Text;
using EjemploDeploy.Domain.Abstract;
using EjemploDeploy.Domain.Entities;

namespace EjemploDeploy.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private herokuContext _ctx;

        public EFProductRepository(herokuContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Product> Products => _ctx.Product;

        public void Save(Product product)
        {
            if (product.ProductId == 0)
            {
                _ctx.Product.Add(product);
            }
            else
            {
                Product dbEntry = _ctx.Product.Find(product.ProductId);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                }
            }

            _ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            Product product = _ctx.Product.Find(id);
            if (product != null)
            {
                _ctx.Product.Remove(product);
            }

            _ctx.SaveChanges();
        }
    }
}
