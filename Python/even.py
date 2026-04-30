# print even number using for loop
a = int(input("Enter a number: "))
print("Even numbers from 1 to", a, "are:")
for i in range(0, a + 1, 2):
    print(i)