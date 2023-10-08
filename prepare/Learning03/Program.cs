using System;

namespace Learning03
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Fraction p1 = new Fraction();
            Console.WriteLine(p1.GetFractionString());
            Console.WriteLine(p1.GetDecimalValue());

            Fraction p2 = new Fraction(5,1);
            Console.WriteLine(p2.GetFractionString());
            Console.WriteLine(p2.GetDecimalValue());

            Fraction p3 = new Fraction(3, 4);
            Console.WriteLine(p3.GetFractionString());
            Console.WriteLine(p3.GetDecimalValue());

            Fraction p4 = new Fraction(1, 3);
            Console.WriteLine(p4.GetFractionString());
            Console.WriteLine(p4.GetDecimalValue());


 
        }
    }
}
