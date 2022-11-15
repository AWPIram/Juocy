using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedscore : MonoBehaviour
{

    player1 playeri;



    public Text speedtext;
    // Start is called before the first frame update
    void Start()
    {
        speedtext = GetComponent<Text>();
        playeri = FindObjectOfType<player1>();
    }

    // Update is called once per frame
    void Update()
    {

        speedtext.text = "PWR:" + playeri.speed;
    }
}
