using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string ipt;
            Console.WriteLine("sex");
            Console.WriteLine("정수 입력 : ");
            abc:
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("결과");
            Console.WriteLine($"더하기 : {num1+num2}");
            Console.WriteLine($"뺴기 : { num1 - num2}");
            Console.WriteLine(num1 * num2);
            Console.WriteLine((double)num1 / num2);
            goto abc;

        }
    }
}
