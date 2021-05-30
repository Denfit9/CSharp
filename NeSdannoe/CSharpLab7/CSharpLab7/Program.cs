using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace СSharpLab7
{
    class Program
    {

        static Fraction FractionCreation(string str)
        {
            int index = str.IndexOf("/");
            if (index != -1)
            {
                int firstArg = int.Parse(str.Substring(0, index));
                int secondArg = int.Parse(str.Substring(index + 1));
                return new Fraction(firstArg, secondArg);
            }
            else
            {
                return new Fraction(int.Parse(str), 1);
            }
        }

        static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9' || c != '/' || c != '.')
                    return true;
            }
            return false;
        }
        static void CheckFraction(ref string str)
        {
            bool isWrongSymb = CheckWrongSymbFraction(str);
            bool isEmpty = CheckStringEmpt(ref str);
            bool isWrongArgs = false;
            bool isRightLength = false;
            if (str.IndexOf("/") != -1)
            {
                isWrongArgs = CheckArgs(ref str, isEmpty);
                isRightLength = (str.Length >= 3) ? false : true;
                if (isRightLength)
                {
                    Console.WriteLine("Wrong line length");
                }
            }

            while ((isEmpty != false) || (isWrongSymb != false) || (isRightLength != false) ||
                  (isWrongArgs != false))
            {
                Console.WriteLine("Try again");
                str = Console.ReadLine();
                isWrongSymb = CheckWrongSymbFraction(str);
                isEmpty = CheckStringEmpt(ref str);
                if (str.IndexOf("/") != -1)
                {
                    isWrongArgs = CheckArgs(ref str, isEmpty);
                    isRightLength = (str.Length >= 3) ? false : true;
                    if (isRightLength)
                    {
                        Console.WriteLine("Wrong line length");
                    }
                }
            }
        }

        static bool CheckArgs(ref string str, bool isEmpty)
        {
            bool isWrongArgs = false;
            int index = str.IndexOf("/");
            string firstArg = str.Substring(0, index);
            bool isFirstArgWrong = CheckWrongSymbInt(firstArg);
            string secondArg = str.Substring(index + 1);
            bool isSecondArgWrong = CheckNotNullOrNegative(secondArg, isEmpty);
            if ((isFirstArgWrong != false) || (isSecondArgWrong != false))
            {
                Console.WriteLine("Wrong arguments");
                isWrongArgs = true;
            }
            isFirstArgWrong = CheckStringEmpt(ref firstArg);
            isSecondArgWrong = CheckStringEmpt(ref firstArg);
            if ((isFirstArgWrong != false) || isSecondArgWrong != false)
            {
                Console.WriteLine("Wrong arguments");
                isWrongArgs = true;
            }
            return isWrongArgs;
        }

        static bool CheckStringEmpt(ref string str)
        {
            bool isEmpty = false;
            str = str.Trim();
            if (str.Length == 0)
            {
                Console.WriteLine("Empty line");
                isEmpty = true;
            }
            else if (str.Length != 0)
            {
                isEmpty = false;
            }
            return isEmpty;
        }

        static bool CheckNotNullOrNegative(string str, bool isEmpty)
        {
            bool isNegative = false;
            if (isEmpty == false)
            {
                if (str[0] == '-' || str[0] == '0')
                {
                    Console.WriteLine("Negative number or zero");
                    isNegative = true;
                }
            }
            return isNegative;
        }

        static void CheckNaturalInt(ref string str)
        {
            bool isWrongSymb = CheckWrongSymbInt(str);
            bool isEmpty = CheckStringEmpt(ref str);
            bool isNegativeOrNull = CheckNotNullOrNegative(str, isEmpty);
            while ((isEmpty != false) || (isWrongSymb != false)
                    || (isNegativeOrNull != false))
            {
                Console.WriteLine("Try again");
                str = Console.ReadLine();
                isWrongSymb = CheckWrongSymbInt(str);
                isEmpty = CheckStringEmpt(ref str);
                isNegativeOrNull = CheckNotNullOrNegative(str, isEmpty);
            }
        }

        static bool CheckWrongSymbFraction(string str)
        {
            bool isWrongSymb = false;
            Regex regExp = new Regex(@"[0-9]");
            Regex regExpSlash = new Regex(@"/");
            MatchCollection match = regExp.Matches(str);
            MatchCollection matchSlash = regExpSlash.Matches(str);
            if ((match.Count != str.Length) && (matchSlash.Count > 1))
            {
                Console.WriteLine("Incorrect input");
                isWrongSymb = true;
            }
            return isWrongSymb;
        }

        static bool CheckWrongSymbInt(string str)
        {
            bool isWrongSymb = false;
            Regex regExp = new Regex(@"[0-9]");
            MatchCollection match = regExp.Matches(str);
            if (match.Count != str.Length)
            {
                Console.WriteLine("Incorrect input");
                isWrongSymb = true;
            }
            return isWrongSymb;
        }

        static Fraction FractionInput(ref Fraction fraction)
        {
            Console.WriteLine("Enter your fraction (ex. 2/3)");
            string fractionStr = Console.ReadLine();
            while (IsDigitsOnly(fractionStr) == false)
            {
                Console.WriteLine("Error. You can't use any symbols here! (except '/') \nEnter your fraction");
                fractionStr = Console.ReadLine();
            }
            CheckFraction(ref fractionStr);
            fraction = FractionCreation(fractionStr);
            Console.WriteLine(fraction);
            return fraction;
        }

        static void Main(string[] args)
        {
            Console.Write("What to do : \n1 - add\n2 - subtract\n3 - multiply\n4 - divide\n5 - compare\n6 - fraction into decimal \n7 - fraction into integer\n8 - exit ");
            string operationChoiceStr = Console.ReadLine();
            CheckNaturalInt(ref operationChoiceStr);
            int Choice = Convert.ToInt32((operationChoiceStr));
            Console.WriteLine("what format will the fraction be shown? \n1 - usual\n2 - special");
            string formatChoiceStr = Console.ReadLine();
            CheckNaturalInt(ref formatChoiceStr);
            int formatChoice = Convert.ToInt32((formatChoiceStr));
            Fraction fraction = new Fraction();
            FractionInput(ref fraction);
            Fraction fraction2 = new Fraction();
            switch (Choice)
            {
                case 1:
                    FractionInput(ref fraction2);
                    Console.WriteLine("Sum is");
                    Fraction.FractionSum(fraction, fraction2, formatChoice);
                    break;
                case 2:
                    FractionInput(ref fraction2);
                    Console.WriteLine("Difference is ");
                    Fraction.FractionDiff(fraction, fraction2, formatChoice);
                    break;
                case 3:
                    FractionInput(ref fraction2);
                    Console.WriteLine("Multiplying result is ");
                    Fraction.FractionMult(fraction, fraction2, formatChoice);
                    break;
                case 4:
                    FractionInput(ref fraction2);
                    Console.WriteLine("Dividing result is ");
                    Fraction.FractionDiv(fraction, fraction2, formatChoice);
                    break;
                case 5:
                    FractionInput(ref fraction2);
                    if (fraction == fraction2)
                    {
                        Console.WriteLine("Fractions are equal");
                    }
                    else if (fraction > fraction2)
                    {
                        Console.WriteLine("First fraction is bigger");
                    }
                    else
                    {
                        Console.WriteLine("Second fraction is bigger");
                    }
                    break;
                case 6:
                    Console.WriteLine(((double)fraction).ToString());
                    break;
                case 7:
                    Console.WriteLine(((int)fraction).ToString());
                    break;
                default:
                    Console.WriteLine("Excellent choice but no");
                    break;
            }

            Console.ReadKey();
        }

    }


}

