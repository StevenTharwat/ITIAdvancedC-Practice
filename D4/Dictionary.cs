namespace D4
{
    internal class Dictionary<T, U>
    {
        List<int> Hashes;
        List<T> keys;
        List<U> values;
        public U this[T key] { set { Add(key, value); } }
        public Dictionary(int _size = 4)
        {
            Hashes = new List<int>();
            keys = new List<T>(_size);
            values = new List<U>(_size);
        }

        public int Add(T key, U value)
        {
            if (key == null || Hashes.Contains(key.GetHashCode())) throw new Exception("key is null or Dublicated");
            else
            {
                Hashes.Add(key.GetHashCode());
                keys.Add(key);
                return values.Add(value);
            }
        }

        public T GetAt(T Key)
        {
            throw new NotImplementedException();
        }

        public int GetCapacity()
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public int Remove(T item)
        {
            throw new NotImplementedException();
        }

        public T RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
