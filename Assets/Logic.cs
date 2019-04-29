using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{
    public GameObject a, b;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            if ((a & b) | (a ^ b))
                print("(a & b) | (a ^ b)");
            if (a ^ b)
                print("a ^ b");
            if (a | b)
                print("a | b");
        }
    }
}
