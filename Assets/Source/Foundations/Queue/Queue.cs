namespace Algorithms.Foundations
{
    public class Queue<T> : IQueue<T>
    {
        private int N;
        private Node<T> last; // new item
        private Node<T> first; // old item

        public bool isEmpty()
        {
            return first == null; // N == 0
        }

        public void enqueue(T item)
        {
            Node<T> oldLast = last;
            last = new Node<T>();
            last.item = item;
            last.next = null;
            if (isEmpty())
            {
                first = last;
            }
            else
            {
                oldLast.next = last;
            }

            N++;
        }

        public T dequeue()
        {
            T item = first.item;
            first = first.next;
            if (isEmpty())
            {
                last = null;
            }

            N--;
            return item;
        }

        public int size()
        {
            return N;
        }
    }

}

