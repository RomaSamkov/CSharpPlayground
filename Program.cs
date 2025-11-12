using System;

namespace CSharpPlayground
// This is a simple C# program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number (radius): ");
            float radius = float.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine(Math.PI);

            Console.WriteLine("Result: " + Math.Round(area));




        }
    }
}
