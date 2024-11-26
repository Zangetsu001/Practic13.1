using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practic13._4
{
    internal class Program
    {
        /// <summary>
        /// Определить статический метод int Seconds (int h, int m, int s),
        /// который принимает три целых аргумента (часы h, минуты m и секунды s)
        /// и возвращает количество секунд, прошедших с начала дня.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int h = Input("Введите h:");
            int m = Input("Введите m:");
            int s = Input("Введите s:");
            int result = Seconds(h, m, s);
            Output(result);
            Console.ReadKey();

        }
        public static int Input(string message)
        {
            Console.Write(message); 
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int Seconds(int h, int m, int s)
        {
            return h * 3600 + m * 60 + s; 
        }
        public static void Output(int result)
        {
            Console.WriteLine(result);
        }
    }
}
