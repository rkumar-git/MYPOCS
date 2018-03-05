Feature: Varify_ValidLogin
	As a User, I should be able to 
	Login to application with valid User Name and Password.

@SmokeTest
Scenario: Varify_ValidLogin
	Given LoginPage is Active
	When Enter valid UserName and Password
	 And Click SignIn Button
	Then Account Summary Page should be displayed
