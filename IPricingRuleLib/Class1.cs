namespace IPricingRuleLib
{
    public interface IPricingRule
    {
        double CalculatePrice(double unitPrice, int quantity);
    }
}
