Feature: Item Browsing feature
	In order to browsing items from the system
	As a user
	I want to test scenarios in our home page  

	Background: user open browser and navigate to our site 
	Given User on the log in page
	When User enter valid username and password
	And  Press Login
	Then The home page should be displayed

	@regression
	Scenario: Verify that all the products displayed and can be filtered by various parameters
	When the user selects <option> from the filter dropdown
	Then the results are sorted according to the <option>
Examples:
	| option              |
	| Name (Z to A)       |
	| Name (A to Z)       |
	| Price (low to high) |
	| Price (high to low) |


	@regression
	Scenario: Verify that the correct product information is displayed on the product detail page
	When The user clicks on an item
	Then  The item information displayed
	
	