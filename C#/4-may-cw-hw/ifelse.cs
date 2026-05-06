internal class Marksheet
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks in Physics: ");
            double physics = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter marks in Chemistry: ");
            double chemistry = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter marks in Maths: ");
            double maths = Convert.ToDouble(Console.ReadLine()); //input

            double percentage = (physics + chemistry + maths) / 3; //formulae

            if (physics < 0 || physics > 100 || chemistry < 0 || chemistry > 100 || maths < 0 || maths > 100)
            {
                Console.WriteLine("Invalid marks entered. Please enter marks between 0 and 100.");
                return;
            }
            string grade = (percentage >= 95) ? $"A+ with {percentage}%" :
                           (percentage >= 90) ? $"A with {percentage}%" :
                           (percentage >= 85) ? $"B+ with {percentage}%" :
                           (percentage >= 80) ? $"B with {percentage}%" :
                           (percentage >= 75) ? $"C+ with {percentage}%" :
                           (percentage >= 70) ? $"C with {percentage}%" :
                           (percentage >= 65) ? $"D+ with {percentage}%" :
                           (percentage >= 60) ? $"D with {percentage}%" :
                            $"You have failed with {percentage}%";

            Console.WriteLine(grade);

        }
    }