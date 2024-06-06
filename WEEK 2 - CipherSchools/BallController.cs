using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;
    
    // Update is called once per frame
    void Update()
    {   
        float horizontalinput = Input.GetAxis("Horizontal");
        float verticalinput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalinput, 0.0f ,verticalinput) * speed * Time.deltaTime;

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement,ForceMode.Impulse);
    }
}
