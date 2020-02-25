namespace Algorithms.Graph
{
    public interface ISearch
    {
        bool marked(int v); // s 与 v 是否连通

        int count(); // 与 s 连通的顶点总数
    }
}

