namespace D4
{
    abstract class DSList<T>
    {
        protected IList<T> list;
        public DSList(IList<T> _list) //later you can send List<T> here if you want
        {
            if (_list == null) throw new NullReferenceException();
            list = _list;
        }
        public virtual int Push(T item)
        {
            return list.Add(item);
        }

        public abstract T Pop();

        public abstract T Peek();

        public override string ToString()
        {
            return list.ToString() ?? string.Empty;
        }
    }
}