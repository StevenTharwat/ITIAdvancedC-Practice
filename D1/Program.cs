namespace D1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(10, 70);
            Complex c2 = new Complex(20, 5);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(( c1 + c2 ).ToString());
            Console.WriteLine(( c1 - c2 ).ToString());
            Console.WriteLine(( c1 * c2 ).ToString());
            Console.WriteLine(( c1 / c2 ).ToString());
            Console.WriteLine(( c1 + 20 ).ToString());
            Console.WriteLine(( c1 - 20 ).ToString());
            Console.WriteLine(( 50 - c1 ).ToString());
            int i = (int) c1;
            Complex c = 5;
            Console.WriteLine(i);
            Console.WriteLine(c.ToString());

            Emp e1 = new Emp("name1", 50, 1000);
            Emp e2 = new Emp("name2", 30, 1500);
            Person e3 = e1 + e2;
            Console.WriteLine(Person.Sum(2, 5, 4, 7));
        }
    }
    public class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public /*virtual*/ static Person operator +(Person p1, Person p2)
        {
            Person p = new Person(p1.Name, 0);
            p.Age = p1.Age + p2.Age;
            return p;
        }

        public static int Sum(params int[] p)
        {
            int res = 0;
            foreach (var item in p)
            {
                res += item;
            }
            return res;
        }
    }

    public class Emp : Person
    {
        public int Salary { get; set; }
        public Emp(string name, int age, int salary) : base(name, age)
        {
            Salary = salary;
        }
    }
}
