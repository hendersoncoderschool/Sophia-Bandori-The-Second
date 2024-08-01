using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int Score = 0;
    public TMP_Text ScoreText;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GameObject.Find("Score").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //print(Score);
        ScoreText.text = "Combo:" + Score;

        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            speed -= 1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            speed += 1;
        }
    }
}
