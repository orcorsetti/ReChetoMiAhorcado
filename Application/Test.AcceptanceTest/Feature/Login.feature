Feature: Login
	In order to login to my hangman application
	As a user
	I want to enter my User name and login

@smoke
Scenario: Perform Login of HangMan Application
	#Steps
	Given the user enter the application
	And he enter her username "orcorsetti"
	When he clicked the login button
	Then the main menu of the app is loaded with the username "orcorsetti"