using System.Collections.Generic;
using MongoDB.Driver;
using MongDbSample.Data.Model;
using MongoDB.Driver.Builders;

namespace MongDbSample.Data
{
    public class ProductInformation : IRepository
    {
        
        public IEnumerable<Products> GetProducts()
        {
            MongoDatabase database = ConnectionInformation.GetConnectionInformation();
            return database.GetCollection<Products>(Commons.Default.CollectionName).FindAll();
        }

        public void AddProduct(Products product)
        {
            MongoDatabase database = ConnectionInformation.GetConnectionInformation();
            database.GetCollection<Products>("Products").Save(product);
        }

        public bool Remove(string id)
        {
            MongoDatabase database = ConnectionInformation.GetConnectionInformation();
            var query = Query<Products>.EQ(e => e.ProductId, id);
            var result = database.GetCollection<Products>("Products").Remove(query);
            return GetById(id) == null;
        }

        public Products GetById(string id)
        {
            MongoDatabase database = ConnectionInformation.GetConnectionInformation();
            var query = Query<Products>.EQ(e => e.ProductId, id);
            return database.GetCollection<Products>("Products").FindOne(query);
        }

        public void Update(Products product)
        {
            MongoDatabase database = ConnectionInformation.GetConnectionInformation();
            var query = Query<Products>.EQ(e => e.ProductId, product.ProductId);
            var update = Update<Products>.Replace(product);
            database.GetCollection<Products>("Products").Update(query, update);
        }
    }
}
