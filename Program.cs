using System;

namespace CSharpPlayground
// This is a simple C# program
{
    class Program
    {
        static void Main()
        {
            int number = 12;
            uint num1 = 10;
            byte num2 = 20;
            long bigNumber = 123456;

            Console.WriteLine(num1 + num2 + bigNumber);
            Console.WriteLine(number);
            number = 41;
            Console.WriteLine("Result: " + number);
        }
    }
}
