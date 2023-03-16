Feature: Site Navigation

In order to navigate links of the system
	As a user
	I want to test scenarios of Burger Menu  
Background: user open browser and navigate to our site 
	Given User on the log in page
	When User enter valid username and password
	And  Press Login
	Then The home page should be displayed

@regressuin
Scenario: Verify that the About link is working correctly
	When the user clicks on the burger menu
	And the user selects About 
	Then the user will be directed to SauceLabs website
