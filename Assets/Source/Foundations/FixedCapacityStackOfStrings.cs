using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Foundations
{
    public class FixedCapacityCapacityStackOfStrings : IFixedCapacityStringStack
    {
        private string[] a;
        private int N;

        public FixedCapacityCapacityStackOfStrings(int cap)
        {
            a = new string[cap];
        }

        public bool isEmpty()
        {
            return N == 0;
        }

        public int size()
        {
            return N;
        }

        public void push(string item)
        {
            a[N++] = item;
        }

        public string pop()
        {
            return a[--N];
        }
    }

}
