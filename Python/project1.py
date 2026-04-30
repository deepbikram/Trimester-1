# store few names and check if Eligible for voting or not by searching string
"""names = ["Random", "Aakash", "Charlie"]
ages = [17, 16, 19]

search_name = input("Enter the name to check eligibility: ")

for i in range(len(names)): # search list of names
    if names[i].lower() == search_name.lower(): # case insensitive system
        if ages[i] >= 18:
            print(names[i], "is eligible to vote.")
        else:
            print(names[i], "is not eligible to vote.")
        break
else:
    print("Name not found.")"""

# Alternative approach using dictionary

people = {
    "random": 17,
    "aakash": 16,
    "charlie": 19,
    "david": 20,
    "eve": 22,
    "frank": 15,
    "grace": 18
}

search_name = input("Enter the name to check eligibility: ").lower()

if search_name in people:
    if people[search_name] >= 18:
        print(search_name.capitalize(), "is eligible to vote.")
    else:
        print(search_name.capitalize(), "is not eligible to vote.")
else:
    print("Name not found.")