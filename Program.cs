using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        /// <summary>
        /// Определить статический метод int Meters (int k, int m),
        /// который принимает два целых аргумента (километры k, метры m) 
        /// и возвращает количество метров. Используя этот метод, 
        /// вычислить количество метров для расстояния:
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int k = Input("Введите k:");
            int m = Input("Введите m: ");
            int result = Meters(k, m);
            Output(result);
            Console.ReadKey();
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int Meters(int k, int m)
        {
            return k * 1000 + m;
        }
        public static void Output(int result)
        {
            Console.WriteLine(result);
        }
    }
}
