Feature: IngresaLetraIncorrecta
	In order to play the game
	As a User
	I want to enter a letter and see if its incorrect

@mytag
Scenario: User enter an incorrect letter
	Given the use enter the username "orcorsetti" and click login
	And the user click star a new game
	And the user enter an incorrect letter "d"
	When the user click the play button
	Then the game shows the letter "d" as incorrect and the remaining attemps are "6"