using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static void sceneMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public static void sceneGame()
    {
        SceneManager.LoadScene("Level 1");
    }
    public static void sceneVolume()
    {
        SceneManager.LoadScene("Volume Mixer");
    }
    public static void sceneHighScore()
    {
        SceneManager.LoadScene("High Scores");
    }
    public static void sceneDirections()
    {
        SceneManager.LoadScene("Directions");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
