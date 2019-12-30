namespace Algorithms.Foundations
{
    public interface IQueue<T>
    {
        bool isEmpty();
        void enqueue(T item);
        T dequeue();
        int size();
    }
}
