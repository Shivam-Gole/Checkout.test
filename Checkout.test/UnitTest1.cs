using System;
using Xunit;
using CheckoutLib;
using IndividualPricingLib;
using SpecialOfferLib;
using ProductLib;
using IProductLib;

namespace CheckoutLib
{
    

    public class CheckoutTests
    {
        private readonly Checkout _checkout;

        public CheckoutTests()
        {
            // Arrange
            var products = new Dictionary<string, IProduct>
        {
            { "A", new Product("A", 50) { PricingRule = new SpecialOffer(3, 130) } },
            { "B", new Product("B", 30) { PricingRule = new SpecialOffer(2, 45) } },
            { "C", new Product("C", 20) { PricingRule = new IndividualPricing() } },
            { "D", new Product("D", 15) { PricingRule = new IndividualPricing() } }
        };

            _checkout = new Checkout(products);
        }

        [Fact]
        public void EmptyStringInput_ReturnsZero()
        {
            // Act
            double total = _checkout.CalculateTotal("");

            // Assert
            Assert.Equal(0, total);
        }

        [Theory]
        [InlineData("A", 50)]
        [InlineData("B", 30)]
        [InlineData("C", 20)]
        [InlineData("D", 15)]
        public void SingleItemSelected_ReturnsIndividualPrice(string sku, double expectedPrice)
        {
            // Act
            double total = _checkout.CalculateTotal(sku);

            // Assert
            Assert.Equal(expectedPrice, total);
        }

        [Theory]
        [InlineData("BB", 45)]
        [InlineData("BBB", 75)]
        public void MultipleItemsOfSameType_ReturnsCorrectPrice(string skus, double expectedPrice)
        {
            // Act
            double total = _checkout.CalculateTotal(skus);

            // Assert
            Assert.Equal(expectedPrice, total);
        }

        [Fact]
        public void MultipleItems_ReturnsSumOfIndividualPrices()
        {
            // Arrange
            string skus = "ABC";

            // Act
            double total = _checkout.CalculateTotal(skus);

            // Assert
            Assert.Equal(100, total);
        }

        [Fact]
        public void StringWithMultipleSKUs_ReturnsSumOfIndividualPrices()
        {
            // Arrange
            string skus = "ABCD";

            // Act
            double total = _checkout.CalculateTotal(skus);

            // Assert
            Assert.Equal(115, total);
        }

        [Fact]
        public void SpecialOffers_ReturnsCorrectPrice()
        {
            // Arrange
            string skus = "AAA";

            // Act
            double total = _checkout.CalculateTotal(skus);

            // Assert
            Assert.Equal(130, total);
        }
    }

}