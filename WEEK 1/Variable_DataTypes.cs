using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable_DataTypes : MonoBehaviour
{   
    int myInt= 5;
    float myFloat = 8.5f;
    bool myBool = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("the value of int : "+myInt);
        Debug.Log("the value of float : "+myFloat);
        Debug.Log("the value of bool : "+myBool);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
