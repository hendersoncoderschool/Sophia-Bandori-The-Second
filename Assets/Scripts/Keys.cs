using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    public string key;
    bool entered;
    public GameManager GameManager;
    public int speed;
    
    // Start is called before the first frame update
    void Start()
    {
        entered = false;
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * 10 * speed);
        if (transform.position.y < -5) {
            GameManager.Score = 0;
            Destroy(gameObject);
        }
        speed = GameManager.speed;
        if (Input.GetKeyDown(key) && entered) {
            GameManager.Score += 1;
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
