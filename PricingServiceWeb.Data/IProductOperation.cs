using PricingServiceWeb.Data.Model;

namespace PricingServiceWeb.Data
{
    public interface IProductOperation
    {
        void Update(AdjustPrice adjustPrice);
    }
}