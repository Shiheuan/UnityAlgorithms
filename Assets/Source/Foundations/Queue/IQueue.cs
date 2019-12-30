using System.Collections;

namespace Algorithms.Foundations
{
    public interface IQueue<T> : IEnumerable
    {
        bool isEmpty();
        void enqueue(T item);
        T dequeue();
        int size();
    }
}
