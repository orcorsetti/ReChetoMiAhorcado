Feature: PierdeJuego
	In order to play the hangman game
	As a User
	I want to be told when i lost the game

@mytag
Scenario: User Losses the game
	Given the user enter her UserName "orcorsetti" and click Login
	And the user start the game
	When the user plays incorrect letters
	| letter |
	| w      |
	| f      |
	| g      |
	| u      |
	| h      |
	| b      |
	| k      | 
	Then the user losses and the game confort her