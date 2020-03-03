namespace Algorithms.Graph
{
    public interface ISymbolGraph
    {
        bool contains(string key);
        int index(string key);
        string name(int v);
        Graph getG();
    }
}

