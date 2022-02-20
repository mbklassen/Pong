using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private int speed = 20;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-1f, 1f) * speed;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Goal1")
        {
            Debug.Log("Player 2 scored");
            rb.velocity = Vector2.zero;
        }
        if (col.gameObject.tag == "Goal2")
        {
            Debug.Log("Player 1 scored");
            rb.velocity = Vector2.zero;
        }
    }
}
