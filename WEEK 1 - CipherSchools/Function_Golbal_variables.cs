using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // a global variable
    int global;
    // Start is called before the first frame update
    void Start()
    {   
        //Calling the function
        Debug.Log(Add(2,4));
        
    }

    // Update is called once per frame
    void Update()
    {
        //Add();
    }

    //My function
    public int Add(int num1, int num2)
    {
        //Debug.Log("This is ADD FUNCTION");
        
        //result is a local variable
        int result = num1 + num2;
        return result;
    }   
}
