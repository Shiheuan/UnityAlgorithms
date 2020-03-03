using Algorithms.Search;
using System;

namespace Algorithms.Graph
{
    public class SymbolGraph : ISymbolGraph
    {
        private SequentialSearchST<string, Int32> st;
        private string[] keys;
        private Graph G;

        public SymbolGraph(string stream, char sp)
        {
            st = new SequentialSearchST<string, Int32>();
            string[] a = stream.Split('\n');
            
            for (int i = 0; i < a.Length; i++)
            {
                string[] b = a[i].Split(sp);
                for (int j = 0; j < b.Length; j++)
                {
                    if (!st.contains(b[j]))
                    {
                        st.put(b[j], st.size()+1); // avoid key 0
                        UnityEngine.Debug.Log($"{st.size()}:{b[j]}");
                    }
                }
                    
            }
            
            keys = new string[st.size()];

            foreach (string name in st.allkeys())
            {
                keys[st.get(name)-1] = name;
                UnityEngine.Debug.Log($"{st.get(name)-1}:{name}");
            }

            G = new Graph(st.size());

            for (int i = 0; i < a.Length; i++)
            {
                string[] b = a[i].Split(sp);
                int v = st.get(b[0])-1;
                for (int j = 1; j < b.Length; j++)
                {
                    G.addEdge(v, st.get(b[j])-1);
                }
            }
        }

        public bool contains(string key)
        {
            return st.contains(key);
        }

        public Graph getG()
        {
            return G;
        }

        public int index(string key)
        {
            return st.get(key)-1;
        }

        public string name(int v)
        {
            return keys[v];
        }
    }
}

