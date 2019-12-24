namespace Algorithms.Foundations
{
    public interface IFixedCapacityStack<T>
    {
        void push(T item);
        T pop();
        bool isEmpty();
        int size();
    }
}

