namespace IntroDemoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("\nPlease enter your Age: ");
            uint userAge = uint.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease enter your height in inches: ");
            double userHeight = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nNice to meet you {userName}, youre age is {userAge} and your height is {userHeight} inches");
          
        }
    }
}
