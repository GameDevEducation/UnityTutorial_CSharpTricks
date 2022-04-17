using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayAndListDemo : MonoBehaviour
{
    List<int> IntValuesList = new List<int>();
    int[] IntValuesArray = new int[5] { 10, 20, 30, 40, 50 };

    // Start is called before the first frame update
    void Start()
    {
        while(IntValuesList.Count < 5)
            IntValuesList.Add(Random.Range(0, 100));

        // Lines A and B are the same
        Debug.Log(IntValuesList[IntValuesList.Count - 1]);  // Line A
        Debug.Log(IntValuesList[^1]);                       // Line B

        Debug.Log(IntValuesArray[^1]);

        int offset = 1;
        Debug.Log(IntValuesArray[^offset]);
        Debug.Log(IntValuesArray[^(offset + 1)]);
        Debug.Log(IntValuesArray[^GetOffset(1)]);

        Debug.Log(IntValuesList[^offset]);
        Debug.Log(IntValuesList[^(offset + 1)]);
        Debug.Log(IntValuesList[^GetOffset(1)]);
    }

    int GetOffset(int offset)
    {
        return offset;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
