namespace D3
{
    internal class Stack
    {
        int top;
        int size;
        int[] arr;
        public Stack(int _size)
        {
            if (_size < 0) throw new Exception("Size must be greater than 0");
            else size = _size;
            arr = new int[size];
            top = -1;
        }
        public void Push(int value)
        {
            top++;
            if (top > size - 1) throw new Exception("Stack Overflow");
            arr[top] = value;
        }
        public int Pop()
        {
            if (top == -1) throw new Exception("stack is empty");
            top--;
            return arr[top + 1];
        }
        public void removeIndex(int index)
        {
            if (index < 0 || index > top) throw new Exception("Index out of range");
            for (int i = index ; i < top ; i++)
            {
                arr[i] = arr[i + 1];
            }
            top--;
        }
    }
}
