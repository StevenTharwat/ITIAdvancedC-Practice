namespace D5
{
    internal class Program
    {
        static int Add(int x, int y, int z)
        {
            Console.WriteLine("add");
            return x + y + z;
        }
        static void hello(string name)
        {
            Console.WriteLine($"HI {name}");
        }
        static void HowAreYou(string name)
        {
            Console.WriteLine($"How Are You {name}");
        }

        static bool IsRight(Predicate<int> predicate)
        {
            return predicate(0);
        }

        static void Main(string[] args)
        {
            string str = "steven";
            List<char> chars = str.FindALL(ch => ch == 'e');
            Console.WriteLine(chars.Count);

            //Point p1 = new() { x = 1, y = 1 };
            //Point p2 = new() { x = 2, y = 2 };
            //Func<int, int, int, int> f1 = Add;
            //f1 += p1.Add;
            //f1 += p2.Add;
            //f1.Invoke(1, 2, 3);


            //Action<string> great = hello;
            //great += HowAreYou;
            //great.Invoke("steven");
            //Console.WriteLine(IsRight(x => x > -1));
        }
    }
}
