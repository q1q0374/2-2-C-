using System;

namespace callbyvalue
{
    class Program
    {

        static void Swap(int x, int y)
        {
            int temp;
            temp = x; x = y; y = temp;
            Console.WriteLine("Swap x= {0}, y= {1}", x, y);
        }
        static void Main(string[] args)
        {
            int x = 1, y = 2;
            Console.WriteLine("before x= {0}, y= {1}",x,y);
            Swap(x, y);
            Console.WriteLine("after x= {0}, y= {1}", x, y);
        }
    }
}
