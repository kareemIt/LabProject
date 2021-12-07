using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    private int time = 99999999;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= 1;

    }
}
