namespace Algorithms.Foundations
{
    public interface IStack<T>
    {
        void push(T item);
        T pop();
        bool isEmpty();
        int size();
    }
}

