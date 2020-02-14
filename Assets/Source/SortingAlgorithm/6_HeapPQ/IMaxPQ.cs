using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public interface IMaxPQ<T> where T : IComparable<T>
    {
        void insert(T v);

        T max();

        T delMax();

        bool isEmpty();

        int size();
    }
}
