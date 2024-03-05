namespace Excercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age? ");
            string ageInput = Console.ReadLine();
            int age = int.Parse(ageInput) + 1;
            Console.WriteLine("The next year you will be " + age + " years old.");
        }
    }
}