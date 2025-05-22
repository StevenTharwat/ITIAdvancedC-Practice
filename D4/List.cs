namespace D4
{
    internal class List<T> : IList<T>
    {
        private T[] arr;
        private int size;
        private int top;
        public T this[int Index] { get { return GetAt(Index); } }

        public List(int _size = 4)
        {
            size = _size;
            arr = new T[size];
            top = -1;
        }
        public List(T[] items) : this(items.Length)
        {
            items.CopyTo(arr, 0);
        }
        /// <summary>
        /// Add item to the list
        /// </summary>
        /// <param name="item"></param>
        /// <returns>index of the item</returns>
        public virtual int Add(T item)
        {
            if (top < size - 1)
            {
                top++;
                arr[top] = item;
                return top;
            }
            else
            {
                Resize();
                return Add(item);
            }
        }

        public virtual T RemoveAt(int index)
        {
            if (index < 0 || index > top) throw new IndexOutOfRangeException();
            T item = arr[index];
            ShiftOn(index);
            top--;
            return item;
        }

        private void ShiftOn(int index)
        {
            for (int i = index ; i < top ; i++)
            {
                arr[i] = arr[i + 1];
            }
        }

        public virtual int Remove(T item)
        {

            for (int i = 0 ; i <= top ; i++)
            {
                if (object.Equals(arr[i], item)) // arr[i].Equals(item) the user can send null and then the top increase but the value is null
                {
                    RemoveAt(i);
                    return i;
                }
            }
            throw new IndexOutOfRangeException("item not founded");
        }
        public virtual T GetAt(int index)
        {
            if (index < 0 || index > top) throw new IndexOutOfRangeException();
            return arr[index];
        }

        public virtual int GetCapacity()
        {
            return size;
        }

        public virtual int GetCount()
        {
            return top + 1;
        }

        public virtual bool Contains(T item)
        {
            return arr.Contains(item);
        }

        void Resize()
        {
            size *= 2;
            T[] newItems = new T[size];
            arr.CopyTo(newItems, 0);
            arr = newItems;
        }

        public override string ToString()
        {
            if (top < 0) return "";
            return $"[{string.Join(", ", arr.Take(top + 1))}]";
        }

        public void TrimExcess()
        {
            size = GetCount();
            T[] newItems = new T[size];
            arr.Take(top + 1).ToArray().CopyTo(newItems, 0);
            arr = newItems;
        }
    }
}
