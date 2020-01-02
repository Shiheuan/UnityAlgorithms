using Algorithms.Foundations;
using Algorithms.Sorting;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string alg1 = "Selection";
        string alg2 = "Insertion";

        int N = 1000;
        int T = 100;

        double t1 = SortCompare.timeRandomInput(alg1, N, T);
        double t2 = SortCompare.timeRandomInput(alg2, N, T);
        print(t1);
        print(t2);

        print($"For {N} random Doubles\n");
        print($"{alg2} is {t1/t2} times faster than {alg1}\n");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
