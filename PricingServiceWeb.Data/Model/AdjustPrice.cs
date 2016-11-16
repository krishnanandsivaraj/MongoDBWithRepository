using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PricingServiceWeb.Data.Model
{
    public class AdjustPrice
    {
        [BsonElement("Catagories")]
        public string Catagories { get; set; }
        [BsonElement("SubCatagories")]
        public string SubCatagories { get; set; }
        [BsonElement("Brand Name")]
        public string BrandName { get; set; }
        [BsonElement("Product Id")]
        public string ProductId { get; set; }
        [BsonElement("Product Name")]
        public string ProductName { get; set; }

        [BsonElement("Price")]
        public string Price { get; set; }
        [BsonElement("Rating")]
        public string Rating { get; set; }
    }
}
