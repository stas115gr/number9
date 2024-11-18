using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int result = Sum(a, b);
            Console.Write($"Сумма = {result}");
            Console.ReadKey();
        }
        public static int Sum(int a, int b)
        {
            return a + b;

        }
    }
}