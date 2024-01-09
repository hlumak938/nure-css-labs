using System;

namespace Lab4_CSS_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntArray arr = new IntArray(5);
            arr.Enter();
            arr.Sort();
            Console.WriteLine("Sorted array:");
            arr.Print();
            Console.WriteLine($"\nArray size = {arr.Size}\n");
            arr.Scalar = 10;
            arr.Print();
        }
    }
}
