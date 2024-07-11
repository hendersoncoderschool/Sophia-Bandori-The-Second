using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    public string key;
    int score;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key)) {
            //Destroy(gameObject);
        }
        if (transform.position.y < -5) {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        Debug.Log("collide");
        if (Input.GetKeyDown(key)) {
            score += 1;
            print("hello");
            Destroy(gameObject);
        }
    }
}
