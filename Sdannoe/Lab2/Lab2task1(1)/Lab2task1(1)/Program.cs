using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2task1_1_
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Time in human format\n");
            Console.WriteLine(DateTime.Now);
            int Zero = 0;
            int One = 0;
            int Two = 0;
            int Three = 0;
            int Four = 0;
            int Five = 0;
            int Six = 0;
            int Seven = 0;
            int Eight = 0;
            int Nine = 0;
            int Hours = Convert.ToInt32(DateTime.Now.Hour);
            string Date = Convert.ToString(DateTime.Now);
            for (int i = 0; i < Date.Length; i++)
            {
                switch (Date[i])
                {
                    case '0':
                        Zero++;
                        break;
                    case '1':
                        One++;
                        break;
                    case '2':
                        Two++;
                        break;
                    case '3':
                        Three++;
                        break;
                    case '4':
                        Four++;
                        break;
                    case '5':
                        Five++;
                        break;
                    case '6':
                        Six++;
                        break;
                    case '7':
                        Seven++;
                        break;
                    case '8':
                        Eight++;
                        break;
                    case '9':
                        Nine++;
                        break;
                }
            }
            Console.WriteLine("This date contains:");
            Console.WriteLine("Zero\tOne\tTwo\tThree\tFour\tFive\tSix\tSeven\tEight\tNine\t");
            Console.WriteLine(Zero + "\t" + One + "\t" + Two + "\t" + Three + "\t" + Four + "\t" + Five + "\t" + Six + "\t" + Seven + "\t" + Eight + "\t" + Nine + "\n\n");
            Console.WriteLine("\nTime in yankee style\n");
             Zero = 0;
             One = 0;
             Two = 0;
             Three = 0;
             Four = 0;
             Five = 0;
             Six = 0;
             Seven = 0;
             Eight = 0;
             Nine = 0;
            String YankeeDate="";
            if (Hours <= 12)
            {
                YankeeDate = Convert.ToString(DateTime.Now);
                string trash = Convert.ToString(Convert.ToString(YankeeDate[3]) + Convert.ToString(YankeeDate[4]));
                string trash2 = Convert.ToString(Convert.ToString(YankeeDate[0]) + Convert.ToString(YankeeDate[1]));
                YankeeDate = YankeeDate.Remove(0, 2);
                YankeeDate = YankeeDate.Insert(0, trash);
                YankeeDate = YankeeDate.Remove(3, 2);
                YankeeDate = YankeeDate.Insert(3, trash2);
                Console.Write(YankeeDate);
                Console.WriteLine(" AM");
            }
            else if (Hours >= 12)
            {
                YankeeDate = Convert.ToString(DateTime.Now.AddHours(-12));
                string trash = Convert.ToString(Convert.ToString(YankeeDate[3]) + Convert.ToString(YankeeDate[4]));
                string trash2 = Convert.ToString(Convert.ToString(YankeeDate[0]) + Convert.ToString(YankeeDate[1]));
                YankeeDate = YankeeDate.Remove(0, 2);
                YankeeDate = YankeeDate.Insert(0, trash);
                YankeeDate = YankeeDate.Remove(3, 2);
                YankeeDate = YankeeDate.Insert(3, trash2);
                Console.Write(YankeeDate);
                Console.WriteLine(" PM");
            }
            for (int i = 0; i < YankeeDate.Length; i++)
            {
                switch (YankeeDate[i])
                {
                    case '0':
                        Zero++;
                        break;
                    case '1':
                        One++;
                        break;
                    case '2':
                        Two++;
                        break;
                    case '3':
                        Three++;
                        break;
                    case '4':
                        Four++;
                        break;
                    case '5':
                        Five++;
                        break;
                    case '6':
                        Six++;
                        break;
                    case '7':
                        Seven++;
                        break;
                    case '8':
                        Eight++;
                        break;
                    case '9':
                        Nine++;
                        break;
                }
            }
            Console.WriteLine("This date contains:");
            Console.WriteLine("Zero\tOne\tTwo\tThree\tFour\tFive\tSix\tSeven\tEight\tNine\t");
            Console.WriteLine(Zero + "\t" + One + "\t" + Two + "\t" + Three + "\t" + Four + "\t" + Five + "\t" + Six + "\t" + Seven + "\t" + Eight + "\t" + Nine + "\n\n");
            Console.ReadKey();
        }
        
    }
}
