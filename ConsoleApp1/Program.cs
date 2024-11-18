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
            Vvod();
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Razn(int a, int b)
        {
            return a - b;
        }
        public static int Proiz(int a, int b)
        {
            return a * b;
        }
        public static int Del(int a, int b)
        {
            return a / b;
        }
        public static void Vvod()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма = {Sum(a, b)}");
            Console.WriteLine($"Разность = {Razn(a, b)}");
            Console.WriteLine($"Произведение = {Proiz(a, b)}");
            Console.WriteLine($"Частное = {Del(a, b)}");
            Console.ReadKey();
        }
    }
}