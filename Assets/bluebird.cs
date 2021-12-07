using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bluebird : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    [SerializeField] Rigidbody2D bullet;
    private int healthb = 10;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            healthb -= 1;
            print("b" + healthb);
        }
        if (healthb == 0)
        {
            SceneManager.LoadScene("Win Screen");
        }
    }

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2 (0, 10);
    }

    void Start()
    {
        InvokeRepeating("spawnEgg", 1.0f, 2.0f );
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