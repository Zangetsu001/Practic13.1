using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// Найти минимальную величину из двух целых переменных 
        /// a, b, используя вспомогательные методы 
        /// (ввода аргументов, нахождения минимальной величины, вывода результата).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = Input("Введите a: ");
            int b = Input("Введите b: ");
            int result = Min(a, b);
            Output(result);
            Console.ReadKey();
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int Min(int a, int b)
        {
            return a < b ? a : b;
        }
        public static void Output(int result)
        {
            Console.Write($"result: {result}");
        }
    }
}
