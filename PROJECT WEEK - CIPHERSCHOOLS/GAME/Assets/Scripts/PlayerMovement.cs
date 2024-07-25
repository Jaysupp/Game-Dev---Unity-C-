using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    
    public float ForwardForce;
    public float SideForce;

    private void FixedUpdate(){
        rb.AddForce(0,0,ForwardForce * Time.deltaTime, ForceMode.VelocityChange);

        if(Input.GetKey("d"))
        {
            //Move Right
            rb.AddForce(SideForce * Time.deltaTime,0,0,ForceMode.VelocityChange);

        }

        if(Input.GetKey("a"))
        {
            //Move Left
            rb.AddForce(-SideForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(rb.position.y < -0.5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }



}
