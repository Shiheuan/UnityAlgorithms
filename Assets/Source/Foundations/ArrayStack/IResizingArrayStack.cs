namespace Algorithms.Foundations
{
    public interface IResizingArrayStack<T>
    {
        void push(T item);
        T pop();
        bool isEmpty();
        int size();
        int capacity();
    }

}

