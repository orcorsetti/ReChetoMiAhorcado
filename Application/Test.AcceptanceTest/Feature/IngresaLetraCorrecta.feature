﻿Feature: PalabraCorrecta
	In order to play the game
	As a User
	I want to enter a letter and see if its correct

@mytag
Scenario: User enter a correct letter
	Given the user enter the username "orcorsetti" and click login
	And the user click to start a new game
	And the user enter a correct letter "s"
	When the user clicked the play button
	Then the game show the letter "s" where it belongs
