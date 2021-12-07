using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemies : MonoBehaviour
{
    // Start is called before the first frame update
    private int enemiesLeft;
    private int numBirds;
    void Start()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        enemiesLeft = enemies.Length;
        numBirds = enemiesLeft;

    }
    

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        enemiesLeft = enemies.Length;
        if (numBirds == 1 && enemiesLeft == 0) 
        {
            SceneManager.LoadScene("Level 2");
        }

        if (numBirds == 2 && enemiesLeft == 0)
        {
            SceneManager.LoadScene("Level 3");
        }
    }
}
