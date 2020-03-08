namespace Algorithms.Graph
{
    public interface IDirectedEdge
    {
        double getWeight();
        int from();
        int to();
        string toString();
    }
}
