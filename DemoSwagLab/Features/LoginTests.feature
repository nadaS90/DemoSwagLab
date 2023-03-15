Feature: Login feature
	In order to login to our system
	As a user
	I want to test All scenarios in our login page  

	Background: user open browser and navigate to our site 
	Given User on the log in page

	@regression
	Scenario: Verify that the user can log in with valid credentials
	When User enter valid username and password
	And  Press Login
	Then The home page should be displayed

	@regression
	Scenario: Verify that the user cannot log in with locked user
	When User enter locked username
	And  Press Login
	Then Error message should be displayed

	@regression
	Scenario: Verify that the user can log in with problem user
	When User enter problem username and password
	And  Press Login
	Then The home page should be displayed with issues

