using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;


    Vector3 movement;


    // Start is called before the first frame update
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //  EI TOIMI rb.MovePosition(rb.position + movement + moveSpeed * Time.fixedDeltaTime);
    }
}
