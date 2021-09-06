using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallInvert : MonoBehaviour
{
    public float moveSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        //Movement stuff, change it however you like
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = -Vector2.right * moveSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * moveSpeed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * moveSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().velocity = -Vector2.up * moveSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //whenever you collide with an object tagged "wall" your controls invert
        if (collision.gameObject.tag == "wall")
        {
            moveSpeed = moveSpeed * -1;
            Destroy(collision.gameObject);
        }      
    }
}
