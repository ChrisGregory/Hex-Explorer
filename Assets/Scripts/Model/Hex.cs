using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex : MonoBehaviour
{
    public string Name { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public float Z { get; set; }

    public Hex(int x, int y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
