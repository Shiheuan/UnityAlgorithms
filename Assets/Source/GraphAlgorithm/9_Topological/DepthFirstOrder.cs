using Algorithms.Foundations;
using System.Collections;

namespace Algorithms.Graph
{
    public class DepthFirstOrder
    {
        private bool[] mark;
        private Queue<object> pre;
        private Queue<object> post;
        private Stack<object> reversePost;

        public DepthFirstOrder(Digraph G)
        {
            pre = new Queue<object>();
            post = new Queue<object>();
            reversePost = new Stack<object>();
            mark = new bool[G.v()];
            for (int v = 0; v < G.v(); v++)
            {
                if (!mark[v])
                    dfs(G, v);
            }
        }

        private void dfs(Digraph G, int v)
        {
            pre.enqueue(v);
            mark[v] = true;
            foreach (int w in G.adj(v))
            {
                if (!mark[w])
                {
                    dfs(G, w);
                }
            }
            post.enqueue(v);
            reversePost.push(v);
        }

        public IEnumerable getPre()
        {
            return pre;
        }

        public IEnumerable getPost()
        {
            return post;
        }

        public IEnumerable getReversePost()
        {
            return reversePost;
        }
    }
}

