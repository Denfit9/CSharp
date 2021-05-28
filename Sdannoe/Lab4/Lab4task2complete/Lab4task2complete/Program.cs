using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Lab4task2complete
{
    class Program
    {
        [DllImport("mymathlib.dll",CallingConvention = CallingConvention.Cdecl)]
        static extern int Sum(int a, int b);
        [DllImport("mymathlib.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Max(int a, int b);
        [DllImport("mymathlib.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Min(int a, int b);

        static int NumCheck()
        {
            string input;
            for ( ; ; )
            {
                input = Console.ReadLine();
                bool check = Int32.TryParse(input, out int newinput);
                if (check) 
                    return newinput;
                Console.WriteLine("\nError");
            }
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("let's find sum \n Type first number");
            num1 = NumCheck();
            Console.WriteLine("Type second number");
            num2 = NumCheck();
            Console.WriteLine(Sum(num1,num2));
            Console.WriteLine("The max number is");
            Console.WriteLine(Max(num1, num2));
            Console.WriteLine("The min number is");
            Console.WriteLine(Min(num1, num2));

        }
    }
}
