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
            SayHello();
            SayBye();
            Console.ReadKey();
        }
        public static void SayHello()
        {
            Console.Write("Привет");
            Console.Read();
        }
        public static void SayBye()
        {
            Console.WriteLine("Пока");
        }
    }
}
