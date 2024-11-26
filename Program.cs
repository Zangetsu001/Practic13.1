using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic13._3
{
    class Program
    {
        /// <summary>
        /// Найти s=min(a, b) + min(c, d), 
        /// используя вспомогательные функции
        /// (ввода аргументов, нахождения минимальной величины, вывода результата).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = Input("Введите a: ");
            int b = Input("Введите b: ");
            int c = Input("Введите c: ");
            int d = Input("Введите d: ");
            int result = Min1(a, b) - Min2(c, d);
            Output(result);
            Console.ReadKey();
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int Min1(int a, int b)
        {
            return a < b ? a : b;
        }
        public static int Min2(int c, int d)
        {
            return c < d ? c : d;
        }
        public static void Output(int result)
        {
            Console.WriteLine(result);
        }

    }
}
