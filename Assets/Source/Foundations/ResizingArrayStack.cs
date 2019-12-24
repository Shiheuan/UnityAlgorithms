namespace Algorithms.Foundations
{
    public class ResizingArrayStack<T> : IResizingArrayStack<T>
    {
        private int N;
        private T[] items;

        public ResizingArrayStack(int cap)
        {
            items = new T[cap];
        }

        private void resize(int cap)
        {
            var temp = new T[cap];
            for (int i = 0; i < this.size(); i++)
            {
                temp[i] = items[i];
            }

            items = temp;
        }

        public void push(T item)
        {
            if (this.size() == items.Length)
            {
                this.resize(items.Length * 2);
            }
            items[N++] = item;
        }

        public T pop()
        {
            var item = items[--N];
            if (this.size() > 0 && this.size() < items.Length / 4)
            {
                resize(items.Length / 2);
            }

            return item;
        }

        public bool isEmpty()
        {
            return N == 0;
        }

        public int size()
        {
            return N;
        }

        public int capacity()
        {
            return items.Length;
        }
    }

}
