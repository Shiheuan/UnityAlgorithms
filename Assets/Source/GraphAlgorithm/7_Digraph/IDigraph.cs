using Algorithms.Foundations;

namespace Algorithms.Graph
{
    public interface IDigraph
    {
        int v();
        int e();
        void addEdge(int v, int w);
        Bag<object> adj(int v);
        //IDigraph reverse();
        string toString();
    }
}

