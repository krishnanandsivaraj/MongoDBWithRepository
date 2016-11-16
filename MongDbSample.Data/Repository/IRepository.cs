using System.Collections.Generic;
using MongDbSample.Data.Model;
using MongoDB.Bson;

namespace MongDbSample.Data
{
    public interface IRepository
    {
        void AddProduct(Products product);
        Products GetById(string id);
        IEnumerable<Products> GetProducts();
        bool Remove(string id);
        void Update(Products product);
    }
}