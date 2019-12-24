using Algorithms.Foundations;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var stack = new FixedCapacityCapacityStackOfStrings(1);
        stack.push("shiheuan");
        print(stack.pop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
