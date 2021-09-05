using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //You need this to...well...manage scenes

public class SceneChangingObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if statement that loads the current (or next) scene
        if (collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene("SampleScene");
            //make sure the scene you want to load when the player collides is added to your build
        }

    }
}
