class Program
{
    static void Main()
    {
        var students = new SortedList<int, string>();

        students.Add(3, "Hari");
        students.Add(1, "Ram");
        students.Add(2, "Sita");

        foreach (var student in students)
        {
            Console.WriteLine(
                student.Key + " : " + student.Value
            );
        }
    }
}