namespace D4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(3);
            list.TrimExcess();
            Console.WriteLine(list.GetCapacity());
            Console.WriteLine(list);


            //Stack<int> st = new(new List<int>());
            //st.Push(1);
            //st.Push(2);
            //st.Push(3);
            //st.Push(4);
            //st.Push(5);
            //st.Push(6);
            //Console.WriteLine(st);
            //Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Pop());

            //Queue<int> que = new(new List<int>());
            //que.Push(1);
            //que.Push(2);
            //que.Push(3);
            //que.Push(4);
            //que.Push(5);
            //que.Push(6);
            //Console.WriteLine(que);
            //Console.WriteLine(que.Pop());
            //Console.WriteLine(que.Pop());
            //Console.WriteLine(que.Pop());
            //Console.WriteLine(que.Pop());
            //Console.WriteLine(que.Pop());
            //Console.WriteLine(que.Pop());

            //Dictionary<Complex, int> map = new Dictionary<Complex, int>();

            //map.Add(new Complex(5, 2), 3);
            //map.Add(new Complex(1, 2), 3);
            //map.Add(new Complex(1, 2), 3); // toString printed once again ??

            //Dictionary<string, int> dic = new Dictionary<string, int>();
            //dic["s1"] = 1;
            //dic["s2"] = 1;
            //dic["s2"] = 5;


        }
    }
}
