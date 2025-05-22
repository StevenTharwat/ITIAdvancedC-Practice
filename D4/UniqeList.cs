namespace D4
{
    internal class UniqeList<T> : List<T>
    {
        List<int> HashArr;

        public UniqeList(int _size = 4) : base(_size)
        {
            HashArr = new List<int>(_size);
        }
        public UniqeList(T[] items) : this(items.Length)
        {
        }

        public override int Add(T item)
        {
            //if the hash code does not found added it else do not add it 
            if (item == null) throw new ArgumentNullException();
            if (!HashArr.Contains(item.GetHashCode()))
            {
                HashArr.Add(item.GetHashCode());
                return base.Add(item);
            }
            return -1;
        }
    }
}
