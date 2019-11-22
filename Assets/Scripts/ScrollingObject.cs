using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private float speed = .9f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -GameController.instance.scrollSpeed * speed);
    }

    void Update()
    {
        if(GameController.instance.gameOver == true)
        {
            rb.velocity = Vector2.zero;
        }
    }
}
