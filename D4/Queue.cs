namespace D4
{
    internal class Queue<T> : DSList<T>
    {
        public Queue(IList<T> _list) : base(_list)
        {
        }

        public override T Peek()
        {
            return list.GetAt(0);
        }

        public override T Pop()
        {
            return list.RemoveAt(0);
        }
    }
}
