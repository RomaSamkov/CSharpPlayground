using System;

namespace CSharpPlayground
// This is a simple C# program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter login: ");
            string login = Console.ReadLine();
            if (login == "Admin")
            {
                Console.WriteLine("Welcome, Admin!");
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Hello, {0}. Your age is {1}.", name, age);
            }
            else
            {
                Console.WriteLine("Access denied.");
            }


        }
    }
}
