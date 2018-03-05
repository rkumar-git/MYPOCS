Feature: LogOut_N_Verify
	As a User,
	I should be able to logout from Application.

@SmokeTest
Scenario: Logout_N_Verify
	Given LoginPage is Active
	And User Authenticated Successfilly
	When I Click SignOut link
	Then User should logout successfully
