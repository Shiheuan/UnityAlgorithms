using Algorithms.Foundations;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var bag = new Bag<object>();
        bag.add(new object());
        bag.add(new object());
        bag.add(new object());
        foreach (var v in bag)
        {
            print(v);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
