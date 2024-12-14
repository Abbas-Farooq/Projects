# Number Guessing Game in C# (1 to 1000)

The Number Guessing Game is an interactive console-based game written in C#. The objective of the game is simple: the program randomly selects a number between 1 and 1000, and the player has to guess that number. The game provides feedback after each guess, telling the player whether their guess is too high, too low, or correct. The game continues until the player successfully guesses the number.

## Gameplay Features:
### Random Number Generation:
At the start of each game, the program generates a random number between 1 and 1000, which the player must guess. This number is kept hidden from the player, who must use logical reasoning and deduction to find it.

### User Input:
The player enters their guesses through the console. After each guess, the game gives feedback:

If the guess is too low, the player is prompted to try a higher number.
If the guess is too high, the player is prompted to try a lower number.
If the guess is correct, the game congratulates the player and displays the number of attempts taken to guess the number correctly.
## Input Validation:
The game ensures that the player's guess is a valid number between 1 and 1000. If the player enters something that isn't a number or an out-of-range value, the game will prompt the user to enter a valid guess.

## Attempt Tracking:
The game keeps track of how many attempts the player has made to guess the number. This encourages players to improve their guessing strategies and provides a sense of achievement when they eventually guess the number.

## Replay Option:
Once the player guesses the correct number, they are given the option to play again. If they choose to do so, the game restarts, generating a new random number.