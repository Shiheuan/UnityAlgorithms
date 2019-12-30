using System.Collections;

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

        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }

        private class Iterator : IEnumerator
        {
            private readonly Queue<T> parent;
            private Node<T> current;

            public Iterator(Queue<T> parent)
            {
                this.parent = parent;
                current = new Node<T>
                {
                    next = parent.first
                };
            }

            public bool MoveNext()
            {
                current = current.next;

                return current != null;
            }

            public void Reset()
            {
                if (this.parent != null)
                    current.next = this.parent.first;
            }

            public object Current
            {
                get
                {
                    if (current.item != null)
                    {
                        return current.item;
                    }

                    return null;
                }
            }
        }
    }

}

