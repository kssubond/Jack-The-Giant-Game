using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody2D rb;
    private Animator anim;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        PlayerMovement();
    }
    void PlayerMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 temp = transform.localScale;
        Vector2 movement = new Vector2(moveHorizontal, 0);
        rb.AddForce(movement * speed);

        if (moveHorizontal > 0)
        {
            anim.SetBool("Walk", true);
            temp.x = 1f;
            transform.localScale = temp;
        }
        else if (moveHorizontal < 0)
        {
            anim.SetBool("Walk", true);
            temp.x = -1f;
            transform.localScale = temp;
        }
        else
        {
            anim.SetBool("Walk", false);
        }
    }
}
