using System.Collections;
using System.Collections.Generic;
using JumpFrog;
using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{
    public Rigidbody2D Rigidbody2D;
    private bool play;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void Play()
    {
        play = true;
    }

    public float speed = 2;
    
    // Update is called once per frame
    void Update()
    {
        if (play)
        {
            if (Input.GetMouseButton(0) && GameManager.Instance.currentState == State.Playing)
            {
                if (Rigidbody2D.gravityScale > -0.2f)
                {
                    Rigidbody2D.gravityScale -= Time.deltaTime * speed;
                }
            }
            else
            {
                if (Rigidbody2D.gravityScale < 0.2f)
                {
                    Rigidbody2D.gravityScale += Time.deltaTime * speed * 1.5f;
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            GameManager.Instance.ShowLose();
        }
    }
}