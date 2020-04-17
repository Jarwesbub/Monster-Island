using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3D : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 10.0f;

    public bool isGrounded;

    public float speed = 12f;
    private Rigidbody rb;
    //public Vector3 movement;
    private Vector3 movement;

    //This is for ItemDrop script to check player collision with NPC's 1-3
    public bool PlayerColNPC1 = false;
    public bool PlayerColNPC2 = false;
    public bool PlayerColNPC3 = false;


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "NPC1")
        {
            PlayerColNPC1 = true;

        }

        if (collider.gameObject.name == "NPC2")
        {
            PlayerColNPC2 = true;

        }

        if (collider.gameObject.name == "NPC3")
        {
            PlayerColNPC3 = true;
           
        }

    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "NPC1")
        {
            PlayerColNPC1 = false;
            
        }

        if (collider.gameObject.name == "NPC2")
        {
            PlayerColNPC2 = false;
            
        }

        if (collider.gameObject.name == "NPC3")
        {
            PlayerColNPC3 = false;
            
        }

    }


    void Start()
    {
        rb = GetComponent<Rigidbody>();


        jump = new Vector3(0.0f, 2.0f, 0.0f);

    }

    void FixedUpdate()
    {
        // transform.Translate(x, y, z)
        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);

       
        GetComponent<Rigidbody>().AddForce(Physics.gravity, ForceMode.Acceleration);
        


    }



    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }



}
