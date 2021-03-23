Feature: UpdateMyName
	Update FirstName in My Appplication

@UpdateMyFirstName

Scenario: UpdateMyFirstNameInMyAccountPage
	Given I login into my App
	When I enter the following details and login
		| UserName                | Password        |
		| pradeepk.jobs@gmail.com | Vishwamitra5$ |
	And I update fisrtname and Passwords as below 
		| firstname | oldPassword     | newPassword   |
		| Pradeep | Vishwamitra5$ | Vishwamitra6$ |
	Then firstname is successfully Updated 