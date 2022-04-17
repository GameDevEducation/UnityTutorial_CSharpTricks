using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringInterpolationDemo : MonoBehaviour
{
    public int Value = 3478;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The value is " + Value + ".");
        Debug.LogFormat("The value is {0}.", Value);
        Debug.Log($"The value is {Value}.");

        Debug.Log($"The random number is {Random.Range(1, 7)}.");
        Debug.Log($"The value is {Random.Range(0f, 1f):0.0}");
        Debug.Log($"The other value is {(5 + Random.Range(1, 100))}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
