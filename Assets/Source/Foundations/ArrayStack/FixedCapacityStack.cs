namespace Algorithms.Foundations
{
    public class FixedCapacityStack<T> : IFixedCapacityStack<T>
    {
        private T[] items;
        private int N;

        public FixedCapacityStack(int cap)
        {
            items = new T[cap];
        }

        public bool isEmpty()
        {
            return N == 0;
        }

        public T pop()
        {
            return items[--N];
        }

        public void push(T item)
        {
            items[N++] = item;
        }

        public int size()
        {
            return N;
        }

    }

}

