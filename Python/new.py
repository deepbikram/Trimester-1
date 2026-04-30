"""
num1 = int(input("Enter the first number: "))
num2 = int(input("Enter the second number: "))

if (num1 > num2):
    print(f"The {num1} is greater than {num2}")
elif (num1 < num2):
    print(f"The {num2} is greater than {num1}")

else:
    print(f"Two numbers {num1} and {num2} are equal:")
"""

"""
num = input("Enter a value: ")

if not num.isdigit() & (int(num) < 0):
    print("That's not a valid integer.")
elif int(num) > 0:
    if int(num) % 2 == 0:
        print(f"{num} is an even number")
    else:
        print(f"{num} is an odd number")
else:
    if int(num) == 0:
        print(f"{num} is zero")"""

""" 3 USERS LOGIN AND HAVE THEIR OWN ACCESS"""

name = ["rahul", "sneha", "priya"]
username = ["admin", "student", "teacher"]
password = ["admin123", "student123", "teacher123"]

user_name = input("Enter your username: ")
user_password = input("Enter your password: ")

if user_name in username:
    idx = username.index(user_name)
    if user_password == password[idx]:
        print(f"Access granted. Welcome {name[idx]}.")
    else:
        print("Access denied. Incorrect password.")
else:
    print("Access denied. Username not found.")