using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Highscore code by alex. goddamnit this project has been giving me a headache. it runs a basic check on if the players score is higher 
//than the already stored value. if it is the currently stored value becomes the players score. Yeah it's nothign special.
public class highScore : MonoBehaviour
{
    Text score;
    int highscore;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        highscore = PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        if(highscore < score1.gs)
        {
            highscore = score1.gs;
            PlayerPrefs.GetInt("highscore" + highscore);
        }
        score.text = ("HIGH SCORE : " + highscore);
    }
}