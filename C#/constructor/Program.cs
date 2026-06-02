//Deft
public Person()
{
    Name = "Unknown";
    Age = 0;
};

//parametr.
""" public Person(string name, int age)
{
    Name = name;
    Age = age;
}
"""

Person person1 = new Person();          // Def
Person person2 = new Person("ABC", 30);  // Paramtr.
person1 person3 = new person1("abc",43);
