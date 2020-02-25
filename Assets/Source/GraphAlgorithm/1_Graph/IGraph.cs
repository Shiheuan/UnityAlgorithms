using System.Collections.Generic;
using Algorithms.Foundations;

namespace Algorithms.Graph
{
    public interface IGraph
    {
        int v();
        int e();
        void addEdge(int v, int w);
        Bag<int> adj(int v);
        string toString();
    }
}

