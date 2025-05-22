namespace D1
{
    public struct Complex
    {
        public double Real { get; set; }
        public double Img { get; set; }
        public Complex(double real = 0, double img = 0)
        {
            Real = real;
            Img = img;
        }
        public override string ToString()
        {
            string res = string.Empty;
            if (Img > 0) res = $"{Real} +{Img}i";
            else if (Img < 0) res = $"{Real} {Img}i";
            else res = $"{Real}";
            return res;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c3 = new Complex(c1.Real, c1.Img);
            c3.Real += c2.Real;
            c3.Img += c2.Img;
            return c3;
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex c3 = new Complex(c1.Real, c1.Img);
            c3.Real -= c2.Real;
            c3.Img -= c2.Img;
            return c3;
        }
        public static Complex operator +(Complex c1, double i)
        {
            Complex c3 = new Complex(c1.Real, c1.Img);
            c3.Real += i;
            c3.Img = c3.Img;
            return c3;
        }
        public static Complex operator -(Complex c1, double i)
        {
            Complex c3 = new Complex(c1.Real, c1.Img);
            c3.Real -= i;
            c3.Img = c3.Img;
            return c3;
        }
        public static Complex operator +(double i, Complex c1)
        {
            return c1 + i;
        }
        public static double operator -(double i, Complex c1)
        {
            return i - c1.Real;
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex c3 = new Complex(c1.Real, c1.Img);
            c3.Real *= c2.Real;
            c3.Img *= c2.Img;
            return c3;
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex c3 = new Complex(c1.Real, c1.Img);
            c3.Real /= c2.Real;
            c3.Img /= c2.Img;
            return c3;
        }
        public static bool operator ==(Complex c1, Complex c2)
        {
            return c1.Real == c2.Real && c1.Img == c2.Img;
        }
        public static bool operator !=(Complex c1, Complex c2)
        {
            return !( c1 == c2 );
        }

        public static implicit operator Complex(double i)
        {
            return new Complex(i);
        }
        public static explicit operator double(Complex c)
        {
            return c.Real;
        }
        public static bool operator >(Complex c1, Complex c2)
        {
            return c1.Real > c2.Real;
        }
        public static bool operator <(Complex c1, Complex c2)
        {
            return c1.Real < c2.Real;
        }
        public static bool operator >=(Complex c1, Complex c2)
        {
            return c1.Real >= c2.Real;
        }
        public static bool operator <=(Complex c1, Complex c2)
        {
            return c1.Real <= c2.Real;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Complex) return this == (Complex) obj;
            else return false;
        }

    }
}
