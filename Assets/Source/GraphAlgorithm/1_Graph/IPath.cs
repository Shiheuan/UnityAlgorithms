using System.Collections;
using Algorithms.Foundations;

namespace Algorithms.Graph
{
    public interface IPath
    {
        bool hasPathTo(int s);
        IEnumerable pathTo(int v); // IEnumerable<int>, edit in Bag
    }
}

