using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    Boolean scorecounted;

    float moveIffset = .1f;
    public static bool gameOver = false;
    Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Bird.gameOver) return;

        float xOffset = transform.position.x + 0.003f;
        transform.position = new Vector3(
            xOffset,
            transform.position.y,
            transform.position.z
            );
        if(Input.touchCount > 0)
        {
            print("Touch Phase  -->  "+Input.GetTouch(0).phase);
        }
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(1).phase == TouchPhase.Began))
        {

            rigidbody2D.velocity = new Vector2(0.5f,2.5f);

        }
  
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        print("OnTriggerEnter2D ---> " + collision.tag);
        gameOver = true;
        // GameOverPopup.SetActive(true);
        rigidbody2D.gravityScale = 0f;
        rigidbody2D.velocity = new Vector2(0f, 0f);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("OnCollisionEnter2D");
    }

}
