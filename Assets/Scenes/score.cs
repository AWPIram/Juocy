using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score1 : MonoBehaviour
{
    public static  int gs;
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

        speedtext.text = "Score:" + gs;
    }
}
