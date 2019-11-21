using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -GameController.instance.scrollSpeed);
    }

    //void Update()
    //{
    //    if(GameController.instance.gameOver == true)
    //    {
    //        rb.velocity = Vector2.zero;
    //    }
    //}
}
