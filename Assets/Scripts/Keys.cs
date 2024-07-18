using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    public string key;
    int score;
    bool entered;
    
    // Start is called before the first frame update
    void Start()
    {
        entered = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * 10);
        if (transform.position.y < -5) {
            Destroy(gameObject);
        }
        if (Input.GetKeyDown(key) && entered) {
            score += 1;
            print("hello");
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        //Debug.Log("collide");
        entered = true;
    }

    void OnTriggerExit2D(Collider2D col) {
        //Debug.Log("collide");
        entered = false;
    }
}
