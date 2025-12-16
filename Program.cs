using System;

namespace CSharpPlayground
// This is a simple C# program
{
    class Program
    {
        static void Main()
        {
            short[] numbers = new short[10];
            short sum = 0;

            Random random = new Random();

            for (byte i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt16(random.Next(-50, 50));
                Console.WriteLine("El: " + numbers[i]);
                sum += numbers[i];
            }
            Console.WriteLine("Sum: " + sum);

        }
    }
}
