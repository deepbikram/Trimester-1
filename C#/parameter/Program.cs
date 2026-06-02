// Normal --> most common

void Show(int x)
{
    Console.WriteLine(x);
}

Show(5);

// Output: 5


// ref --> change original variable

void Add(ref int x)
{
    x = x + 5;
}

int num = 10;

Add(ref num);

Console.WriteLine(num);

// Output: 15




// out --> return value from method

void GetNumber(out int x)
{
    x = 50;
}

int number;

GetNumber(out number);

Console.WriteLine(number);

// Output: 50




// optional --> default value if no value passed

void Greet(string name = "Guest")
{
    Console.WriteLine(name);
}

Greet();
Greet("John");

// Output:
// Guest
// John




// named --> pass value using parameter name

void Student(string name, int age)
{
    Console.WriteLine(name);
    Console.WriteLine(age);
}

Student(age: 20, name: "Ali");

// Output:
// Ali
// 20




// params --> accept many values

void Numbers(params int[] nums)
{
    foreach (int n in nums)
    {
        Console.WriteLine(n);
    }
}

Numbers(1, 2, 3, 4);

// Output:
// 1
// 2
// 3
// 4
