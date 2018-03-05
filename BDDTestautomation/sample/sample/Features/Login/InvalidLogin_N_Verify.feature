Feature: InvalidLogin_N_Verify
	As a User, When I enter invalid username and password
	warning message shold be triggered.

@SmokeTest
Scenario: Verify_InvalidLogin_Warning
	Given LoginPage is Active
	When Enter Invalid UserId and Password
	Then Warning message should be displayed
		And LoginPage should Persist