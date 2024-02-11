using IPricingRuleLib;
namespace IndividualPricingLib
{
    public class IndividualPricing : IPricingRule
    {
        public double CalculatePrice(double unitPrice, int quantity)
        {
            return unitPrice * quantity;
        }
    }
}
