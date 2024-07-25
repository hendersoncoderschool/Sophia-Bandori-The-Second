using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    int timer = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1;
        if (timer == 0) {
            GameObject.Find("music").SetActive(true);
        }
    }
}
