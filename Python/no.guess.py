"""This is a no-guessing game where the player tries to guess a randomly generated number between 1 and 100. The player has a limited number of attempts to find the correct number. The game provides feedback on whether the player's guess is too low, too high, or correct. The player can also choose to exit the game at any time."""

import random

number = random.randint(1, 100)
print("Guess the number (1-100):")

for attempt in range(3):
    guess = input(f"Attempt {attempt}: ")

    if not guess.isdigit():
        print("Enter a valid number.")
        continue

    guess = int(guess)
    if guess == number:
        print("Correct! You win.")
        break
    elif guess < number:
        print("Guess higher.")
    else:
        print("Guess lower.")

else:
    print(f"No attempts left! The number was {number}.")
