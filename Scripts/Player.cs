using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public Rigidbody2D rb;
    private float fixedXPosition;
    void Start()
    {
        fixedXPosition = transform.position.x;
    }
    private void Update()
    {
        transform.position = new Vector2(fixedXPosition, transform.position.y);
        //transform.Translate(transform.right * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "GameController")
        {
            Destroy(other.gameObject);
        }
    }
}
