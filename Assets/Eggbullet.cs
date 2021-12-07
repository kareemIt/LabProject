using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eggbullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public AudioSource audio;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2 (-5f, 0 );
    }
    void Start()
    {
        if (audio == null)
            audio = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(audio.clip, transform.position);
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
        {
            if (rb.position.x <= -10) {
                Destroy(gameObject);
            }
        }
}
