internal class Age
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            string msg = (age <= 18) ? "Go and Study hard..." : 
                        (age > 18 && age < 55) ? "Hop on to a Party Mate.." : 
                        (age >= 55 && age <= 120) ? "You are a senior citizen, take care of your health and enjoy your life..." :
                        "Invalid age entered. Please enter an age between 0 and 120.";

            Console.WriteLine(msg);
        }

    }