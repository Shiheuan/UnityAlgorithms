using NUnit.Framework;

namespace Algorithms.Sorting
{
    public class TestShell
    {
        [Test]
        public void sort_InputStringArray_AscendingOrder()
        {
            string[] s = { "S", "O", "R", "T", "E", "X", "A", "M", "P", "L", "E" };
            Shell.sort(s);
            Assert.True(BaseSort.isSorted(s));
        }
    }
}

