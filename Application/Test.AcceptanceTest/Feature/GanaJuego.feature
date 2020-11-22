Feature: GanaJuego
	In order to win the game
	As a User
	I want to know when i win

@mytag
Scenario: User Wins the Game
	Given the user enter her UserName "orcorsetti" and click the Login button
	And the user starts the game
	And the user plays the correct letters
	| letter |
	| s      |
	| a      |
	| l      |
	| e      |
	| r      |
	| o      |
	Then the user wins the game and the game congratulates her