using System.Collections;

namespace Algorithms.Foundations
{
    public class Bag<T> : IBag<T>, IEnumerable
    {
        private Node<T> first;
        public void add(T item)
        {
            var oldfirst = first;
            first = new Node<T>();
            first.item = item;
            first.next = oldfirst;
        }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }

        private class Iterator : IEnumerator
        {
            private readonly Bag<T> bag;
            private Node<T> current;

            public Iterator(Bag<T> bag)
            {
                this.bag = bag;
                current = new Node<T>
                {
                    next = bag.first
                };
            }

            public bool MoveNext()
            {
                current = current.next;

                return current != null;
            }

            public void Reset()
            {
                if (this.bag != null)
                    current.next = this.bag.first;
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
