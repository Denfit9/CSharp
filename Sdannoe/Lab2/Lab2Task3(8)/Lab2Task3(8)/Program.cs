using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab2Task3_8_
{
    class Languages
    {
        public static void France()
        {
            for (int i = 0; i <= 12; i++)
            {
                DateTime France = new DateTime(2021, 1, 1);
                Console.WriteLine(France.AddMonths(i).ToString("MMMM", CultureInfo.GetCultureInfo("fr-FR")));
            }
        }
        public static void Russian()
        {
            for (int i = 0; i <= 12; i++)
            {
                DateTime Russian = new DateTime(2021, 1, 1);
                Console.WriteLine(Russian.AddMonths(i).ToString("MMMM", CultureInfo.GetCultureInfo("ru-RU")));
            }
        }
        public static void English()
        {
            for (int i = 0; i <= 12; i++)
            {
                DateTime English = new DateTime(2021, 1, 1);
                Console.WriteLine(English.AddMonths(i).ToString("MMMM", CultureInfo.GetCultureInfo("en-EN")));
            }
        }
        public static void Polish()
        {
            for (int i = 0; i <= 12; i++)
            {
                DateTime Polish = new DateTime(2021, 1, 1);
                Console.WriteLine(Polish.AddMonths(i).ToString("MMMM", CultureInfo.GetCultureInfo("pl-PL")));
            }
        }
        public static void German()
        {
            for (int i = 0; i <= 12; i++)
            {
                DateTime German = new DateTime(2021, 1, 1);
                Console.WriteLine(German.AddMonths(i).ToString("MMMM", CultureInfo.GetCultureInfo("de-DE")));
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int Switcher = 0;
            char Contin;
            int End = 0;
            Console.WriteLine("What language do you want to use?");
            Console.WriteLine("\ntype\n1 - France\n2 - Russian\n3 - English\n4 - Polish\n5 - German");
            while (End == 0)
            {
                Switcher = (Console.ReadKey().KeyChar);
                while (Switcher < '1' || Switcher > '5')
                {
                    Console.WriteLine("Use only numbers from 1 to 5");
                    Switcher = Console.ReadKey().KeyChar;
                }
                Switcher = Convert.ToInt32(Switcher) - 48;
                Console.WriteLine("\n");
                switch (Switcher)
                {
                    case 1:
                        Languages.France();
                        break;
                    case 2:
                        Languages.Russian();
                        break;
                    case 3:
                        Languages.English();
                        break;
                    case 4:
                        Languages.Polish();
                        break;
                    case 5:
                        Languages.German();
                        break;
                }
                Console.WriteLine("Again? y/n");
                Contin = Convert.ToChar(Console.ReadKey().KeyChar);
                if (Contin == 'n')
                {
                    End++;

                }
                else
                {
                    while (Contin != 'y' && Contin != 'n')
                    {

                        Console.WriteLine("\ny - Yes, n - No");
                        Contin = Console.ReadKey().KeyChar;
                        if (Contin == 'n')
                        {
                            End++;
                        }
                    }
                }
                Console.Clear();
                Console.WriteLine("What language do you want to use?");
                Console.WriteLine("\ntype\n1 - France\n2 - Russian\n3 - English\n4 - Polish\n5 - German");
            }
        }
    }
}
