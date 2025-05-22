namespace D3
{
    internal class Program
    {
        static void Swap<T>(ref T obj1, ref T obj2)
        {
            T temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            Swap(ref a, ref b);
            Queue stack = new Queue(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine("remove index 2");
            stack.removeIndex(2);
            stack.Push(7);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
