using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public float thresholdY = 0;

    private bool isDead = false;

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

        if (GameController.instance.gameOver == true)
        {
            if (transform.position.y < thresholdY)
            {
                GameController.instance.PlayerDied();
                Destroy(gameObject);
            }
        }
    }
    void PlayerMovement()
    {
        if (isDead == false)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            Vector3 temp = transform.localScale;
            Vector2 movement = new Vector2(moveHorizontal, 0);
            rb.AddForce(movement * speed);

            if (moveHorizontal > 0)
            {
                anim.SetBool("Walk", true);
                temp.x = 1.4f;
                transform.localScale = temp;
            }
            else if (moveHorizontal < 0)
            {
                anim.SetBool("Walk", true);
                temp.x = -1.4f;
                transform.localScale = temp;
            }
            else
            {
                anim.SetBool("Walk", false);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Deadly"))
        {
            GameController.instance.PlayerDied();
            Destroy(gameObject);
        }
    }
}
