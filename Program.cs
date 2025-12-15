using System;

namespace CSharpPlayground
// This is a simple C# program
{
    class Program
    {
        static void Main()
        {
            byte[] nums = new byte[5];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 4;
            nums[4] = 5;

            string[] names = { "Alice", "Bob", "Charlie" };

            for (byte i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

        }
    }
}
