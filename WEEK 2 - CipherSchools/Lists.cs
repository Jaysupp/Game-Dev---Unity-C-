using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{   
    List<string> myList = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        myList.Add("John");
        myList.Add("Dante");
        myList.Add("Jacob");

        for(int i = 0; i< myList.Count; i++){
            Debug.Log("Names: "+myList[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
