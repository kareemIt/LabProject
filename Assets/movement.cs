using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    Rigidbody2D body;
    [SerializeField] Rigidbody2D bullet;
    public int Health = 100;
    public int healthbar;

    float horizontal;
    float vertical;

    public float runSpeed = 10.0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown("space"))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }

    void Damaged()
    {
        Health -= 10;
        healthbar = Health;
        print(Health);
        if (Health <= 0)
        {
            SceneManager.LoadScene("Level 1");
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("eggbullet"))
        {
            Damaged();
        }
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);  
        
    }
}
