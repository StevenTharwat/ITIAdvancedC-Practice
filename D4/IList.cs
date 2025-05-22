namespace D4
{
    internal interface IList<T>
    {
        public int Add(T item);
        public int Remove(T item);
        public T RemoveAt(int index);
        public T GetAt(int index);
        public int GetCapacity();
        public int GetCount();
        public void TrimExcess();
    }
}
