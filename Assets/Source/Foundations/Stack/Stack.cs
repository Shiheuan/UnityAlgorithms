using System.Collections;

namespace Algorithms.Foundations
{
    public class Stack<T> : IStack<T>
    {
        private Node<T> first;
        private int N;
        public void push(T item)
        {
            var oldfirst = first;
            first = new Node<T>
            {
                item = item,
                next = oldfirst
            };
            N++;
        }

        public T pop()
        {
            N--;
            var item = first.item;
            first = first.next;
            return item;
        }

        public bool isEmpty()
        {
            return first == null;
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
            private readonly Stack<T> parent;
            private Node<T> current;

            public Iterator(Stack<T> parent)
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

