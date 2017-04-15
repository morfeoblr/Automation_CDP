Feature: AddToCart
	As an user I want to be able to Add items to Cart page

@ignore
Scenario: Open Start page
Given I have logged into the application
Then the page title should be proper

Scenario Outline: Auto-navigation to the Cart page once item is added to the Cart
Given I have navigated to page with url '<Link>'
When I click on first returned item
When I click on Add to Cart button
Then I expect to be navigated to the Cart page
Examples: 
| Link |
| http://www.ebay.com/rpp/computers-networking |
| http://www.ebay.com/rpp/camera-photo         |

Scenario: Selected item is added to the Cart page
Given I have navigated to Camera page
| Links										   |
| http://www.ebay.com/rpp/camera-photo |
When I click on first returned item
And I click on Add to Cart button
Then I expect to see selected item on the Cart page

Scenario Outline: User is able to add valid quantity of items
Given I have navigated to Camera page
| Links |
| http://www.ebay.com/rpp/camera-photo         |
When I click on first returned item
And I enter non-defailt quantity of items '<quantity>'
And I click on Add to Cart button
Then I expect to see entered value of items on the Cart page
Examples: 
| quantity |
| 2 |
| 3 |

Scenario Outline: User is not able to add item to Cart page with invalid count number
Given I have navigated to Camera page
| Links |
| http://www.ebay.com/rpp/camera-photo         |
When I click on first returned item
And I enter non-defailt quantity of items '<quantity>'
And I click on Add to Cart button
Then I expect to see red hint under count field
Examples: 
| quantity |
| 0        |
| -1       |

Scenario: Add to Cart button is not presented for item already added to the Cart page
Given I have navigated to Camera page
| Links |
| http://www.ebay.com/rpp/camera-photo         |
When I click on first returned item
When I click on Add to Cart button
And I navigate to just added Item page
Then I expect to see text saying that this item is already added to the Cart page


