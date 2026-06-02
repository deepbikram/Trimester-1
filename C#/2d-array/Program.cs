// write a 2d array of integers and print the sum of each row

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[3, 3];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = i + j;
            }
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            Console.WriteLine($"Sum of row {i}: {sum}");
        }
    }
}
