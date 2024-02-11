using IProductLib;
using IndividualPricingLib;
namespace CheckoutLib
{
    public class Checkout
    {
        private readonly Dictionary<string, IProduct> _products;

        public Checkout(Dictionary<string, IProduct> products)
        {
            _products = products;
        }

        public double CalculateTotal(string skus)
        {
            var itemCounts = new Dictionary<string, int>();
            foreach (var sku in skus)
            {
                if (_products.TryGetValue(sku.ToString(), out var product))
                {
                    if (itemCounts.ContainsKey(sku.ToString()))
                    {
                        itemCounts[sku.ToString()]++;
                    }
                    else
                    {
                        itemCounts[sku.ToString()] = 1;
                    }
                }
            }

            double total = 0;
            foreach (var item in itemCounts)
            {
                var product = _products[item.Key];
                var pricingRule = product.PricingRule ?? new IndividualPricing();
                total += pricingRule.CalculatePrice(product.UnitPrice, item.Value);
            }

            return total;
        }
    }
}
