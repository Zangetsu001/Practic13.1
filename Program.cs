using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic13._2
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = Input("Введите a:");
            int b = Input("Введите b:");
            int c = Input("Введите c:");
            int result = Min(Min(a, b), c);
            Output(result);
            Console.Read();

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
            Console.WriteLine(result);
        }

    }
}
