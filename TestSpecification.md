#
1.Empty String Input

Given: An empty string input.
When: Calculating the price with an empty string input.
Then: The total price should be 0.

2.Single Item is selected

Given: An input string containing a single SKU, e.g., "A".
When: Calculating the price for a single SKU.
Then: The total price should be the individual price of the item corresponding to the SKU.

3.Multiple Items of the Same Type

Given: An input string containing multiple occurrences of the same SKU, e.g., "BB".
When: Calculating the price for multiple items of the same type.
Then: The total price should reflect any special offers applicable to the SKU.

4.Multiple Items

Given: An input string containing multiple SKUs, e.g., "ABC".
When: Calculating the price for multiple items with different SKUs.
Then: The total price should be the sum of individual prices for each SKU.

5.String with Multiple SKUs

Given: An input string containing multiple SKUs, e.g., "ABCD".
When: Calculating the price for a string with multiple SKUs.
Then: The total price should be the sum of individual prices for each SKU.

6.Special Offers

Given: An input string containing multiple occurrences of a SKU eligible for a special offer, e.g., "AAA".
When: Calculating the price for items eligible for special offers.
Then: The total price should reflect the special offer for the SKU.

1. Empty String Input
Given: ""
When: Price with empty strings.
Then: return 0.

2. Single Item is selected
Given: "A".
When: single SKU
Then: return 50;

3. Given: "BB".
When: 
Then: return 45;

4. Multiple Items
Given: "ABC"
When: String with multiple SKUs
Then: return 100 ;

5. 
Given: "ABCD"
When: String has multiple SKUs
Then : return 15;

6. Special Offers
Given: "AAA"
When: special offers
Then: return 130;
