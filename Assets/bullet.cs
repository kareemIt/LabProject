using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audio;
    private Rigidbody2D rb;

    private  void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2 (5f, 0 );
    }

    void Start()
    {
        if (audio == null)
            audio = GetComponent<AudioSource>();
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("BlueBird"))
        {
            AudioSource.PlayClipAtPoint(audio.clip, transform.position);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.x >= 10) {
            Destroy(gameObject);
        }
        
    }
}
