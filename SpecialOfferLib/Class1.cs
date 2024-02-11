using IPricingRuleLib;
namespace SpecialOfferLib
{
    public class SpecialOffer : IPricingRule
    {
        public int Quantity { get; }
        public double DiscountedPrice { get; }

        public SpecialOffer(int quantity, double discountedPrice)
        {
            Quantity = quantity;
            DiscountedPrice = discountedPrice;
        }

        public double CalculatePrice(double unitPrice, int quantity)
        {
            return quantity / Quantity * DiscountedPrice + (quantity % Quantity) * unitPrice;
        }
    }
}
