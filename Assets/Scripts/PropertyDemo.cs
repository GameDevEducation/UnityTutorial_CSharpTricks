using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyDemo : MonoBehaviour
{
    public int VisibleVariable1;
    [SerializeField] int _VisibleVariable2;

    [field: SerializeField, Range(0, 10)] public int VisibleVariable3 { get; private set; } = 10;

    public int VisibileVariable2 => _VisibleVariable2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
