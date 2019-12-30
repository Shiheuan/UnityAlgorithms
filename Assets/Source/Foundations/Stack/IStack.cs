using System.Collections;

namespace Algorithms.Foundations
{
    public interface IStack<T>:IEnumerable
    {
        void push(T item);
        T pop();
        bool isEmpty();
        int size();
    }
}

