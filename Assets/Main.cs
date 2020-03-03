using Algorithms.Foundations;
using Algorithms.Sorting;
using Algorithms.Graph;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string alg1 = "Shell";
        string alg2 = "Merge";

        int N = 10000;
        int T = 100;

        double t1 = SortCompare.timeRandomInput(alg1, N, T);
        double t2 = SortCompare.timeRandomInput(alg2, N, T);
        print(t1);
        print(t2);

        print($"For {N} random Doubles\n");
        print($"{alg2} is {t1/t2} times faster than {alg1}\n");

        var g = new Graph(13);
        g.addEdge(0, 5);
        g.addEdge(4, 3);
        g.addEdge(0, 1);
        g.addEdge(9, 12);
        g.addEdge(6, 4);
        g.addEdge(5, 4);
        g.addEdge(0, 2);
        g.addEdge(11, 12);
        g.addEdge(9, 10);
        g.addEdge(0, 6);
        g.addEdge(7, 8);
        g.addEdge(9, 11);
        g.addEdge(5, 3);

        var cc = new ConnectedComponent(g);
        print(cc.getCount());

        string str = "jfk,mco\nord,den\nord,hou\ndfw,phx\njfk,atl\nord,dfw\nord,phx\natl,hou\nden,phx\nphx,lax\njfk,ord\nden,las\ndfw,hou\nord,atl\nlas,lax\natl,mco\nhou,mco\nlas,phx";
        //print(str);
        var sg = new SymbolGraph(str, ',');

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
