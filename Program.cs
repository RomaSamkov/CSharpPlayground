using System;

namespace CSharpPlayground
// This is a simple C# program
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) continue;
                Console.WriteLine("Number: " + i);
            }
            // int i = 0;
            // while (i < 10)
            // {
            //     Console.WriteLine("Number: " + i);
            //     i++;
            // }
            // bool isAdmin = false;
            // while (!isAdmin)
            // {
            //     Console.Write("Write name: ");
            //     string name = Console.ReadLine();
            //     if (name == "Admin")
            //     {
            //         isAdmin = true;
            //     }
            // }
            // int i = 0;
            // do
            // {
            //     Console.WriteLine("Number: " + i);
            //     i++;
            // } while (i < 10);

        }
    }
}
