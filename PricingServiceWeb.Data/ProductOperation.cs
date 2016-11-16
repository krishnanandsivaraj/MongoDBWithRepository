using MongoDB.Driver;
using PricingServiecWeb.Data;
using PricingServiceWeb.Data.Model;
using MongoDB.Driver.Builders;

namespace PricingServiceWeb.Data
{
    public class ProductOperation : IProductOperation
    {
        public void Update(AdjustPrice adjustPrice)
        {

            MongoDatabase database = ConnectionInformation.GetConnectionInformation();
            var query = Query<AdjustPrice>.EQ(e => e.ProductId, adjustPrice.ProductId);
            var update = Update<AdjustPrice>.Replace(adjustPrice);
            database.GetCollection<AdjustPrice>("Products").Update(query, update);
        }
    }
}
