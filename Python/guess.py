"""this is a simple number guessing game but it is fixed to win by the bot because everytime the bot will always choose the number that is 11 minus the user's guess. The guess number is always between 1 and 10.  If the final number is 100 when human adds their number to bot then human wins and vice versa. There is no number of attemps and the game continues until the user or bot reaches 100."""

import random

def no_guessing_game():
    total = 0
    print("Game start! First to reach 100 wins.")
    while total < 100:
        try:
            human_guess = int(input("Enter a number between 1 and 10: "))
        except ValueError:
            print("Invalid input. Please enter a number.")
            continue

        if human_guess < 1 or human_guess > 10:
            print("Invalid guess. Please try again.")
            continue

        bot_guess = random.randint(1, 10)
        print(f"Bot guess is: {bot_guess}")
        total += human_guess + bot_guess
        print(f"Current total: {total}")

        if total >= 100:
            break

    if total == 100:
        print("Congratulations! You win!")
    else:
        print("Bot wins! Better luck next time.")

no_guessing_game()