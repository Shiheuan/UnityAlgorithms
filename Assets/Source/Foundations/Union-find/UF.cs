namespace Algorithms.Foundations
{
    public class UF : IUF
    {
        private int[] id;
        private int N;

        public UF(int n)
        {
            id = new int[n];
            N = n;
            for (var i = 0; i < N; i++)
            {
                id[i] = i;
            }
        }
        public void union(int p, int q)
        {
            var pId = find(p);
            var qId = find(q);

            if (pId == qId) return;

            for (var i = 0; i < id.Length; i++)
            {
                if (id[i] == pId)
                {
                    id[i] = qId;
                }
            }

            N--;
        }

        public int find(int p)
        {
            return id[p];
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

