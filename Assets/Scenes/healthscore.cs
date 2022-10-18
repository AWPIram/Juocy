using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthscore : MonoBehaviour
{

    player1 player;
    
    
    
    public Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        scoretext = GetComponent<Text>();
        player = FindObjectOfType<player1>();
    }

    // Update is called once per frame
    void Update()
    {

        scoretext.text = "HP:" + player.phealth;
    }
}
