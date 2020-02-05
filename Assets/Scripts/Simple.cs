using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple : MonoBehaviour
{
    //Create a reference variable for the original script.
    public Basic basic;

    void Start()
    {

    }
    
    void Update()
    {
        if (basic.age > 2000)
            Debug.Log("I'm soo old");
    }
}
