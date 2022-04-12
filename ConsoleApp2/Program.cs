//using System;

//namespace MyApp
//{
//    internal class Program
//    {
//        struct XY
//        {
//            private int X { get; set; }
//            private int Y { get; set; }
//            public XY(int x,int y)
//            {
//                X = x;Y = y;
//            }
//            public override string ToString()
//            {
//                return $"X is {X}\nY is {Y}";
//            }
//        }
//        static void Main(string[] args)
//        {
//            XY xy = new XY(1,3);
//            Console.WriteLine(xy);
//        }
//    }
//}

////////////////

using System;

namespace MyApp
{
    class Fraction
    {
        private double Nume { get; set; }
        private double Denom { get; set; }

        public Fraction(double numerator, double denominator)
        {
            Nume = numerator;
            Denom = denominator;
        }
        public Fraction Add( Fraction Other)
        {
            double Numerator = 0;
            if (Nume == Other.Nume) Denom = Denom + Other.Denom;
            else
            {
                Numerator = Nume * Other.Nume;
                Denom = (Denom * (Numerator / Nume)) + (Other.Denom * (Numerator / Other.Nume));
                Nume = Numerator;
            }
            return this;
        }
        public Fraction Minus(Fraction Other)
        {
            double Numerator = 0;
            if (Nume == Other.Nume) Denom = Denom + Other.Denom;
            else
            {
                Numerator = Nume * Other.Nume;
                Denom = (Denom * (Numerator / Nume)) - (Other.Denom * (Numerator / Other.Nume));
                Nume = Numerator;
            }
            return this;
        }
        public Fraction Multiply(Fraction Other)
        {
            Nume = Nume * Other.Nume;
            Denom = Denom * Other.Denom;
            return this;
        }
        public Fraction Divded(Fraction Other)
        {
            Nume = Nume * Other.Denom;
            Denom = Denom * Other.Nume;
            return this;
        }
        public override string ToString() {
            double num1, num2 = 0;
            bool isokay = true;
            for (var i = Nume; i >=1; i--)
            {
                if (Nume%i==0)
                {
                    num1 = i;
                    for(var j = Denom; j >=1; j--)
                    {
                        if()
                    }
                }
            }



            return $"{Nume}/{Denom}"; 
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(2, 3);
            //Fraction f3 = f1.Add(f2);
            //Fraction f3 = f1.Minus(f2);
            //Fraction f3 = f1.Divded(f2);
            Fraction f3 = f1.Multiply(f2);
            Console.WriteLine(f3);
        }
    }
}