using System;
using System.Threading;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 7, 4, 6 } ;
            int[] array2 = { 18, 4, 74, 8 };

            for (int i = 0; i <= (array.Length) - 1; i++)
            {
                Thread.Sleep(200);
                //Console.WriteLine("Array: " + array[i] + "x" + array2[i] + " = " + (array[i] * array2[i]));
                Console.WriteLine("Array: {0}x{1} = {2}", array[i], array2[i], array[i] * array2[i]);
            }
            Console.ReadLine();
        }
    }
}
