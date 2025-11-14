using System;

namespace CSharpPlayground
// This is a simple C# program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number or login.");
            string user_input = Console.ReadLine() ?? string.Empty;

            switch (user_input)

            {
                case "Admin":
                    Console.WriteLine("Welcome, Admin!");
                    break;
                case "6":
                    Console.WriteLine("You selected option 6");
                    break;
                case "12":
                    Console.WriteLine("You selected option 12");
                    break;
                case "31":
                    Console.WriteLine("You selected option 31");
                    break;
                default:
                    Console.WriteLine("You selected default");
                    break;

            }


        }
    }
}
