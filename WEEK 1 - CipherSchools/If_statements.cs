using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_statements : MonoBehaviour
{

    //If the age is greater than 18, he can vote
    public int age;

    // Start is called before the first frame update
    void Start()
    {
        if(age > 18){
            Debug.Log("You are eligible to vote!");
        }
        else{
            Debug.Log("You are not eligible to vote!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
