using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace СSharpLab7
{
    class Fraction : IComparer<Fraction>
    {
        public Fraction()
        {

        }

        public Fraction(int numerator, int denomerator)
        {
            this.numerator = numerator;
            this.denomerator = denomerator;
        }

        public double ToDouble()
        {
            double doubleFraction = (double)numerator / (double)denomerator;
            return doubleFraction;
        }

        public int ToInt()
        {
            double doubleFraction = (double)numerator / (double)denomerator;
            Console.WriteLine(doubleFraction);
            int intFraction = (int)Math.Round(doubleFraction, MidpointRounding.AwayFromZero);
            return intFraction;
        }

        public override string ToString()
        {
            int numeratorLength = numerator.ToString().Length;
            int denomeratorLength = denomerator.ToString().Length;
            int hyphenLength = (numeratorLength > denomeratorLength) ? numeratorLength : denomeratorLength;
            string hyphen = "";
            for (int i = 0; i < hyphenLength; i++)
            {
                hyphen += "-";
            }
            return numerator.ToString() + "\n" + hyphen + "\n" + denomerator.ToString() + "\n";
        }

        public string ToSpecialString()
        {
            string numeratorSpecialString = "";
            numeratorSpecialString = "I think your number is " + numerator + "out of " + denomerator;
            return numeratorSpecialString;
        }
        public static explicit operator double(Fraction fraction)
        {
            double doubleFraction = (double)fraction.numerator / (double)fraction.denomerator;
            return doubleFraction;
        }

        public static explicit operator int(Fraction fraction)
        {
            double doubleFraction = (double)fraction.numerator / (double)fraction.denomerator;
            Console.WriteLine(doubleFraction);
            int intFraction = (int)Math.Round(doubleFraction, MidpointRounding.AwayFromZero);
            return intFraction;
        }

        public static Fraction operator +(Fraction firstArg, Fraction secondArg)
        {
            if (firstArg.denomerator == secondArg.denomerator)
            {
                Fraction fraction = new Fraction(firstArg.numerator + secondArg.numerator, firstArg.denomerator);
                Reduction(ref fraction);
                return fraction;
            }
            else
            {
                int temp = firstArg.denomerator;
                firstArg.denomerator *= secondArg.denomerator;
                firstArg.numerator *= secondArg.denomerator;
                secondArg.denomerator *= temp;
                secondArg.numerator *= temp;
                Fraction fraction = new Fraction(firstArg.numerator + secondArg.numerator, firstArg.denomerator);
                Reduction(ref fraction);
                return fraction;
            }

        }
        public static Fraction operator -(Fraction firstArg, Fraction secondArg)
        {
            if (firstArg.denomerator == secondArg.denomerator)
            {
                return new Fraction(firstArg.numerator - secondArg.numerator, firstArg.denomerator);
            }
            else
            {
                int temp = firstArg.denomerator;
                firstArg.denomerator *= secondArg.denomerator;
                firstArg.numerator *= secondArg.denomerator;
                secondArg.denomerator *= temp;
                secondArg.numerator *= temp;
                Fraction fraction = new Fraction(firstArg.numerator - secondArg.numerator, firstArg.denomerator);

                return fraction;
            }
        }
        public static Fraction operator *(Fraction firstArg, Fraction secondArg)
        {
            return new Fraction(firstArg.numerator * secondArg.numerator, firstArg.denomerator * secondArg.denomerator);
        }
        public static Fraction operator /(Fraction firstArg, Fraction secondArg)
        {
            return new Fraction(firstArg.numerator * secondArg.denomerator, firstArg.denomerator * secondArg.numerator);
        }

        public static bool operator >(Fraction firstArg, Fraction secondArg)
        {
            Reduction(ref firstArg);
            Reduction(ref secondArg);
            Fraction comparer = new Fraction();
            int result = comparer.Compare(firstArg, secondArg);
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Fraction firstArg, Fraction secondArg)
        {
            Reduction(ref firstArg);
            Reduction(ref secondArg);
            Fraction comparer = new Fraction();
            int result = comparer.Compare(firstArg, secondArg);
            if (result == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Fraction firstArg, Fraction secondArg)
        {
            Reduction(ref firstArg);
            Reduction(ref secondArg);
            Fraction comparer = new Fraction();
            int result = comparer.Compare(firstArg, secondArg);
            if (result == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Fraction firstArg, Fraction secondArg)
        {
            Reduction(ref firstArg);
            Reduction(ref secondArg);
            Fraction comparer = new Fraction();
            int result = comparer.Compare(firstArg, secondArg);
            if (result != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static int CommonDenominator(Fraction fraction)
        {
            int numerator = Math.Abs(fraction.numerator);
            int denomerator = Math.Abs(fraction.denomerator);
            while (denomerator != 0 && numerator != 0)
            {
                if (numerator % denomerator > 0)
                {
                    int temp = numerator;
                    numerator = denomerator;
                    denomerator = temp % denomerator;
                }
                else
                {
                    return denomerator;
                }
            }
            if (denomerator != 0 && numerator != 0)
            {
                return denomerator;
            }
            return denomerator;
        }

        public static void Reduction(ref Fraction fraction)
        {
            int cd = CommonDenominator(fraction);
            fraction.numerator /= cd;
            fraction.denomerator /= cd;
        }

        public void SetNumerator(int value)
        {
            numerator = value;
        }
        public void SetDenomerator(int value)
        {
            denomerator = value;
        }
        public int GetNumerator()
        {
            return numerator;
        }
        public int GetDenomerator()
        {
            return denomerator;
        }
        public int Compare(Fraction firstArg, Fraction secondArg)
        {
            if (firstArg.GetDenomerator() == secondArg.GetDenomerator())
            {
                if (firstArg.GetNumerator() > secondArg.GetNumerator())
                {
                    return 1;
                }
                else if (firstArg.GetNumerator() == secondArg.GetNumerator())
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                int temp = firstArg.GetDenomerator();
                firstArg.SetDenomerator(firstArg.GetDenomerator() * secondArg.GetDenomerator());
                firstArg.SetNumerator(firstArg.GetNumerator() * secondArg.GetDenomerator());
                secondArg.SetDenomerator(secondArg.GetDenomerator() * temp);
                secondArg.SetNumerator(secondArg.GetNumerator() * temp);
                if (firstArg.GetNumerator() > secondArg.GetNumerator())
                {
                    return 1;
                }
                else if (firstArg.GetNumerator() == secondArg.GetNumerator())
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
        public static void FractionSum(Fraction firstArg, Fraction secondArg, int variantOfInput)
        {
            if (variantOfInput == 1)
            {
                Console.WriteLine(firstArg + secondArg);
            }
            else
            {
                Console.WriteLine((firstArg + secondArg).ToSpecialString());
            }

        }


        public static void FractionDiff(Fraction firstArg, Fraction secondArg, int variantOfInput)
        {
            if (variantOfInput == 1)
            {
                Console.WriteLine(firstArg - secondArg);
            }
            else
            {
                Console.WriteLine((firstArg - secondArg).ToSpecialString());
            }

        }


        public static void FractionMult(Fraction firstArg, Fraction secondArg, int variantOfInput)
        {
            if (variantOfInput == 1)
            {
                Console.WriteLine(firstArg * secondArg);
            }
            else
            {
                Console.WriteLine((firstArg * secondArg).ToSpecialString());
            }
        }
        public static void FractionDiv(Fraction firstArg, Fraction secondArg, int variantOfInput)
        {
            if (variantOfInput == 1)
            {
                Console.WriteLine(firstArg / secondArg);
            }
            else
            {
                Console.WriteLine((firstArg / secondArg).ToSpecialString());
            }
        }

        private int numerator { get; set; }
        private int denomerator { get; set; }
    }
}

