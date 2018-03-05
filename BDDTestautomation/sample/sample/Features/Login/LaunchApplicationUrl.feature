Feature: LaunchApplicationUrl
	As User, I shoud be able launch the 
	Application in a browser

@smokeTest
Scenario: LaunchApplication
	Given Browser opened and active
	When I enter the Application Url 
	Then Application should Launch
		And The EMail field should be displayed and enabled
		And The Password field should be displayed and enabled
		And Login Button should be displayed N enabled
		And Forget Password link should be displayed N enabled