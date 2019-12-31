namespace Algorithms.Foundations
{
    public interface IUF
    {
        void union(int p, int q);
        int find(int p);
        bool connected(int p, int q);
        int count();
    }
}

