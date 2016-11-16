using System.Collections.Generic;
using MongDbSample.Data;
using MongDbSample.Data.Model;

namespace MongDbSample.Repository
{
    public class ProductRepository : IRepository
    {
        ProductInformation productContext = new ProductInformation();
        public void AddProduct(Products product)
        {
            productContext.AddProduct(product);
        }

        public Products GetById(string id)
        {
           return productContext.GetById(id);
        }

        public IEnumerable<Products> GetProducts()
        {
            return productContext.GetProducts();
        }

        public bool Remove(string id)
        {
            return productContext.Remove(id);
        }

        public void Update(Products product)
        {
            productContext.Update(product);
        }
    }
}