using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3D : MonoBehaviour
{
    public float speed = 12f;
    private Rigidbody rb;
    //public Vector3 movement;
    private Vector3 movement;

    //public float fall = -0.1f;

    


    void Start()
    {
        rb = GetComponent<Rigidbody>();

        
    }

    void FixedUpdate()
    {
        // transform.Translate(x, y, z)
        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);

       
        GetComponent<Rigidbody>().AddForce(Physics.gravity*2, ForceMode.Acceleration);
        
        
        
        
        /////movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        /*
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        movement = new Vector3(hAxis, fall, vAxis) * speed * Time.deltaTime;




        rb.velocity = (movement * speed);
        */


    }




}
