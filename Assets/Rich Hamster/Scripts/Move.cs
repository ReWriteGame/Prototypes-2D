using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void directionMove(Vector2 direction)
    {
        rb.MovePosition(rb.position + direction);
    }


    public void right()
    {
        directionMove(Vector2.right);
    }
    public void left()
    {
        directionMove(Vector2.left);
    }

    public void up()
    {
        directionMove(Vector2.up);
    }
    public void down()
    {
        directionMove(Vector2.down);
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) left();
        if (Input.GetKey(KeyCode.D)) right();
        if (Input.GetKey(KeyCode.W)) up();
        if (Input.GetKey(KeyCode.S)) down();
    }

}
