using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private int speed = 30;
    private bool movingRight;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movingRight = (Random.value > 0.5);
        Debug.Log(movingRight);
        if (movingRight)
        {
            rb.velocity = new Vector2(Random.Range(1f,2f), 1f).normalized * speed;
        }
        else
        {
            rb.velocity = new Vector2(Random.Range(-1f, -2f), 1f).normalized * speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Goal1")
        {
            Debug.Log("Player 2 scored");
            rb.velocity = Vector2.zero;
            GlobalVariables.player2Score++;
            SceneManager.LoadScene("GameScene");
        }
        if (col.gameObject.tag == "Goal2")
        {
            Debug.Log("Player 1 scored");
            rb.velocity = Vector2.zero;
            GlobalVariables.player1Score++;
            SceneManager.LoadScene("GameScene");
        }
    }
}
