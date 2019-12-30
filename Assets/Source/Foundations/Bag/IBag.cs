using System.Collections;

namespace Algorithms.Foundations
{
    public interface IBag<T>
    {
        void add(T item);

        IEnumerator GetEnumerator();
    }

}

