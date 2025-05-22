namespace D4
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }

        public Complex(int _real, int _img)
        {
            Real = _real;
            Img = _img;
        }
        public override string ToString()
        {
            Console.WriteLine("to string");
            if (Img > 0) return $"{Real} +{Img}I";
            else if (Img < 0) return $"{Real} {Img}I";
            else return Real.ToString();
        }
        public override bool Equals(object? obj)
        {
            Console.WriteLine("Equals");
            if (obj == null || obj.GetType() != GetType()) return false;
            Complex comp = (Complex) obj;
            return comp.Real == Real && comp.Img == Img;
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
