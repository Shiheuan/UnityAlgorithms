namespace Algorithms.Foundations
{
    public class Stack<T> : IStack<T>
    {
        private Node<T> first;
        private int N;
        public void push(T item)
        {
            var oldfirst = first;
            first = new Node<T>();
            first.item = item;
            first.next = oldfirst;
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
    }

}

