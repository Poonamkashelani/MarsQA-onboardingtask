Feature: Login
	Login to the Profile Page with valid Username and Password

@Login
Scenario: Login to website
	Given User have open the browser and User have navigated to the Url
	When User provide correct Username and Password and press sign in
	Then User successfuly login to Home page
