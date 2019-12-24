using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Foundations
{
    public interface IFixedCapacityStringStack
    {
        void push(string item);
        string pop();
        bool isEmpty();
        int size();
    }

}

