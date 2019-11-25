using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private float speed = 2f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -GameControl.instance.scrollSpeed * speed);
    }

    void Update()
    {
        if(GameControl.instance.gameOver == true)
        {
            rb.velocity = Vector2.zero;
        }
    }
}
