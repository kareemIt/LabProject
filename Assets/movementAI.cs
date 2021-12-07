using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movementAI : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    [SerializeField] Rigidbody2D bullet;
    private int health = 5;
    private int enemiesLeft;
    private int birds = 0;
    
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health -= 1;
        }

        if (health <= 0)
        {
            Destroy(gameObject);
            birds++;
            print("birds" + birds);
        }
    }

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2 (0, 10);
    }

    void Start()
    {
        InvokeRepeating("spawnEgg", 3.0f, 4.0f );
    }
    void FixedUpdate() {

        if(transform.position.y >= 4 ){
            rb.velocity = new Vector2(0, -14);
        }
        if(transform.position.y <= -4 ){
            rb.velocity = new Vector2 (0, 14);
        }
    }

    void spawnEgg()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
