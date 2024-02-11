using IPricingRuleLib;
namespace IProductLib
{
    public interface IProduct
    {
        string SKU { get; }
        double UnitPrice { get; }
        IPricingRule PricingRule { get; set; }
    }
}
