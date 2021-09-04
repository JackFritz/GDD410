using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{
    

    public float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }

        //Slow Motion Code
        if(Input.GetKeyDown("space"))
        {
            //slows down time
            Time.timeScale = 0.5f;
            //makes the transition less choppy, feel free to mess around with it
            //Had help making slow mo less choppy with this video https://youtu.be/p_lazukfQtw
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }
        if(Input.GetKeyUp("space"))
        {
            //puts time back to normal
            Time.timeScale = 1;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }
    }
}
