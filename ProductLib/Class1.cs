using IPricingRuleLib;
using IProductLib;
namespace ProductLib
{
    public class Product : IProduct
    {
        public string SKU { get; }
        public double UnitPrice { get; }
        public IPricingRule PricingRule { get; set; }

        public Product(string sku, double unitPrice)
        {
            SKU = sku;
            UnitPrice = unitPrice;
        }
    }
}
