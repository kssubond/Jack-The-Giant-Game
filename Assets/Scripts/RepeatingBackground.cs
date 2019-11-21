using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundVerticalLength;

    void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundVerticalLength = groundCollider.size.y;
    }

    void Update()
    {
        if(transform.position.y > groundVerticalLength)
        {
            RepositionBackground();
        }
    }

    void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(0, -groundVerticalLength * 2f);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
