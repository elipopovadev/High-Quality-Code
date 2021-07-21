using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Numbers(new int[] { 1, 2, 3, 4, 5 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
