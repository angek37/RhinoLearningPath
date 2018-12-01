using System;
using System.Collections.Generic;
using System.Text;
using EjemploDeploy.Domain.Entities;

namespace EjemploDeploy.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        void Save(Product product);
        void Delete(int id);
    }
}
