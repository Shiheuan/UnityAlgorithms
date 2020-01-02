using System;
using NUnit.Framework;

namespace Algorithms.Sorting
{
    
    public class TestSelection
    {
        
        [Test]
        //[TestCase()]
        //public void sort_InputStringArray_AscendingOrder(IComparable[] a)
        public void sort_InputStringArray_AscendingOrder()
        {
            string[] s = {"S", "O", "R", "T", "E", "X", "A", "M", "P", "L", "E"};
            Selection.sort(s);
            Assert.True(BaseSort.isSorted(s));
        }

    }
}

