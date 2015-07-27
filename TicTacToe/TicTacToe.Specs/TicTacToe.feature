@setup_feature
Feature: TicTacToe
	In order to determine who (if anyone) has won the game
	As the game manager
	I want to check the board for a winner

Scenario: When the board is empty there should be no winner
	Given I have an empty Tic Tac Toe board
	When I determine a winner
	Then the result should be a tie

Scenario: When X has all the spaces in the top row then X wins
	Given I have an empty Tic Tac Toe board
	And I put an 'X' in the top left space
	And I put an 'X' in the top middle space
	And I put an 'X' in the top right space
	When I determine a winner
	Then the result should be that 'X' wins

Scenario: When Y has all the spaces in the top row then Y wins
	Given I have an empty Tic Tac Toe board
	And I put an 'Y' in the top left space
	And I put an 'Y' in the top middle space
	And I put an 'Y' in the top right space
	When I determine a winner
	Then the result should be that 'Y' wins

Scenario: When X has all the spaces in the left column then X wins
	Given I have an empty Tic Tac Toe board
	And I put an 'X' in the top left space
	And I put an 'X' in the middle left space
	And I put an 'X' in the bottom left space
	When I determine a winner
	Then the result should be that 'X' wins

Scenario: When X has a diagonal row from top left to bottom right then X wins
	Given I have an empty Tic Tac Toe board
	And the board looks like this
		| col1 | col2 | col3 |
		| X    | O    |      |
		|      | X    | O    |
		| O    |      | X    |
	When I determine a winner
	Then the result should be that 'X' wins