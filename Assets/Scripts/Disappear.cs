using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    int timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 100 * 10;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1;
        if (timer == 0) {
            Destroy(gameObject);
        }
    }
}
