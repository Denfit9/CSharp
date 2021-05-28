using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2task2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            String Line = Console.ReadLine();
            for (int i = 0; i <= Line.Length-1; i++)
            {
                while (Line.Contains("  ")){
                    Line = Line.Replace("  ", " ");
                }
                if (Line[i] < 65 && Line[i] != 32 && Line[i] != 45 || Line[i] >= 91 && Line[i] < 97 || Line[i] > 122)
                {
                    int correctness = 0;
                    while (correctness == 0)
                    {
                        Console.WriteLine("Use only english characters");
                        string Line2 = Console.ReadLine();
                        while (Line2.Contains("  "))
                        {
                            Line2 = Line2.Replace("  ", " ");
                        }
                        for (int j = 0; j <= Line2.Length-1; j++)
                        {
                            if (Line2[j]>=65 && Line2[j]<=91 || Line2[j] <=122 && Line2[j]>=97 || Line2[j]==45 || Line2=="")
                            {
                                correctness++;
                                Line = Line2;
                            }
                        }
                    }
                    
                } 
                
            }
            string[] Words = Line.Split(' ');
            for (int i = Words.Length -1; i >= 0; i--)
            {
                Console.Write(Words[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
