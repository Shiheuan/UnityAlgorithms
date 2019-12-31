namespace Algorithms.Foundations
{
    public class UF : IUF
    {
        private int[] id;
        private int[] sz;
        private int N;

        public UF(int n)
        {
            id = new int[n];
            N = n;
            for (var i = 0; i < N; i++)
            {
                id[i] = i;
            }
            sz = new int[n];
            for (var i = 0; i < N; i++)
            {
                sz[i] = 1;
            }
        }
        public void union(int p, int q)
        {
            // get root
            var pId = find(p);
            var qId = find(q);

            if (pId == qId) return;

            if (sz[pId] < sz[qId])
            {
                id[pId] = qId;
                sz[qId] += sz[pId];
            }
            else
            {
                id[qId] = pId;
                sz[pId] += sz[qId];
            }

            N--;
        }

        public int find(int p)
        {
            while (id[p] != p)
            {
                p = id[p];
            }

            return p;
        }

        public bool connected(int p, int q)
        {
            return find(p) == find(q);
        }

        public int count()
        {
            return N;
        }
    }
}

