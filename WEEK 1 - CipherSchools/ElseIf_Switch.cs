using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElseIf_Switch : MonoBehaviour
{

    //public int age;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        /*if (age < 18){
            Debug.Log("You are a Teenager!");
        }
        else if(age >= 18 && age <60){
            Debug.Log("You are an Adult!");
        }
        else{
            Debug.Log("You are old!");
        }*/
        switch(score)
        {
            case 10:
                Debug.Log("Perfect Score!");
                break;
            case 5:
                Debug.Log("The score is Half!");
                break;
            default:
                Debug.Log("The score is not good enough!");
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
