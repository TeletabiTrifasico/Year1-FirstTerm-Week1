namespace Excercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            int result = number + number;
                
            result += 10;

            result /= 2;

            result -=  number;

            Console.WriteLine($"Result is {result}");
        }
    }
}