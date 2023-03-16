Feature: ShoppingCartTests

	In order to purchase items from the system
	As a user
	I want to test scenarios in our cart page  

	Background: user open browser and navigate to our site 
	Given User on the log in page
	When User enter valid username and password
	And  Press Login
	Then The home page should be displayed

@regression
	Scenario: Verify that user can add products to the cart
	When the user adds items to the cart
	And the user navigates to the Cart page
	Then the item will be added to the cart
	When the user removes an item to the cart
	Then the item will be removed to the cart

@regression
	Scenario: Verify that the user can successfully complete the checkout process
	When the user adds items to the cart
	When the user navigates to the Cart page
	And the user clicks on checkout button
	When the user fills the mandatory fields
	And the user clicks on continue button
	Then the overview details will be displayed
	When the user clicks on finish button
	Then the item is purchased and success message appear
