namespace Excercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
                {
                int result = 0;
                int addon = 1;
                Random rnd = new Random();
                Console.WriteLine("You have to add ");
                for (int i = 0; i < 4; i++) 
                {
                    int number = rnd.Next(101, 10000);
                    Console.WriteLine($"Number{addon}: {number}");
                    addon++;
                    result += number;
                }
                string input = Console.ReadLine();
                int usersAnswer = int.Parse(input);
                if (usersAnswer == result )
                {
                    Console.WriteLine("Well done!!!");
                    result = 0;
                    break;
                }
                else
                {
                    Console.WriteLine("The result is = " + result);
                    Console.WriteLine("Try again!");
                    Console.WriteLine();
                    result = 0;
                }
            }
        }
    }
}