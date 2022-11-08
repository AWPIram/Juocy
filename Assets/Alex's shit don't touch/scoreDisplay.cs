using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Score display code made by yours truly, Alex. Doing my fastest  to make this work. Also fuck TextMeshPro. BEHÖVDE GÖRA OM ALLT DETTA FÖR ATT FÅ DET ATT FUNKA. AAAAAAAAAAA
//AAAAAA AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAaaa. okay. I am going to personally go to Unity headquarters and uninstall Textmeshpro. Thats it thanks. Enjoy
//this basically empty code cause well all it does is display score. What can I say, nothing impressive.
public class scoreDisplay : MonoBehaviour
{
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "HIGH SCORE : " + score1.gs;
    }
}
