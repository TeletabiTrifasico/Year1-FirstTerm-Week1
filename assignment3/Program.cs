namespace Excercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read the users name
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            //read last name
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            //display full name (first option)
            Console.WriteLine("Your full name is " + firstName + " " + lastName);

            //display full name (second option)
            Console.WriteLine("Your full name is {0} {1}", firstName, lastName);

            //display full name (third option)
            Console.WriteLine($"Your full name is {firstName} {lastName}");
        }
    }
}