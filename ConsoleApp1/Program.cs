using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[8];
            int[] array = { 37, 0, 50, 46, 34, 46, 0, 13 }; 
            foreach (int element in array)
            {
                Console.Write($"{element}");
            }
            Console.Read();
        }
    }
}
