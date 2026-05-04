System.Console.WriteLine("Enter a character: ");
char ch = Convert.ToChar(Console.ReadLine());

switch (ch)
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine($"{ch} is a vowel.");
        break;
    default:
        Console.WriteLine($"{ch} is not a vowel.");
        break;
}