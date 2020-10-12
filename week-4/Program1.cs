
using System;


namespace z
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a; a = b; b = temp;
            Console.WriteLine("Swap:x={0},y={1}", a, b);

        }
        static void Main(string[] args)
        {
            int x = 1, y = 2;
            Console.WriteLine("Before: x={0},y={1}", x, y);
            Swap(ref x, ref y);
            Console.WriteLine("after: x={0},y={1}", x, y);


        }
    }
}
