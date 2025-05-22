namespace D4
{
    internal class Stack<T> : DSList<T>
    {
        public Stack(IList<T> _list) : base(_list)
        {
        }

        public override T Peek()
        {
            return list.GetAt(list.GetCount() - 1);
        }

        public override T Pop()
        {
            return list.RemoveAt(list.GetCount() - 1);
        }
    }
}
