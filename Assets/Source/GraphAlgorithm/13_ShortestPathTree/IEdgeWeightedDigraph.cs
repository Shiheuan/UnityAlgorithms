using System.Collections;

namespace Algorithms.Graph
{
    public interface IEdgeWeightedDigraph
    {
        int v();
        int e();
        void addEdge(DirectedEdge e);
        IEnumerable adj(int v);
        IEnumerable edges();
        string toString();
    }
}

