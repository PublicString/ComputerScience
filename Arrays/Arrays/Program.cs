using System;
using System.Threading;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 7, 4, 6 };

            for (int i = 0; i <= (array.Length) - 1; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine("Array: {0}", array[i]);
            }
            Console.ReadLine();
        }
    }
}
