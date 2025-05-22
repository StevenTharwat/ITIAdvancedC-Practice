namespace D3
{
    internal class Queue
    {
        int top;
        int size;
        int[] arr;
        public Queue(int _size)
        {
            top = -1;
            size = _size;
            arr = new int[size];
        }

        public void Push(int value)
        {
            top++;
            if (top > size - 1) throw new Exception("Queue Overflow");
            arr[top] = value;
        }

        public int Pop()
        {
            if (top < 0) throw new Exception("Queue is empty");
            int turn = arr[0];
            for (int i = 0 ; i < top ; i++)
            {
                arr[i] = arr[i + 1];
            }
            top--;
            return turn;
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
