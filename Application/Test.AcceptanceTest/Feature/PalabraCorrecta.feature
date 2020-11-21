Feature: PalabraCorrecta
	In order to play the game
	As a User
	I want to enter a letter and see if its correct

@mytag
Scenario: User anter a correct letter
	Given the user enter a correct letter "s"
	When the user clicked the play button
	Then the game show the letter "s" where it belongs