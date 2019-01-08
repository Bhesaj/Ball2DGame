using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 10f;
    public Joystick myJs;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        float x = myJs.Horizontal;
        float y = myJs.Vertical;
        rb.velocity = new Vector2(x * speed,y * speed );
           
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Goal")
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
