using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Enemyscript : MonoBehaviour
{
    float k = 0.2f;
    score1 score;
    player1 player;
    [SerializeField]
    int kespeed;

    public static float espeed;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<player1>();
        espeed += kespeed;

    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position -= new Vector3(0, espeed, 0) * Time.deltaTime;


       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "blt")
        {
            espeed += k;
            score1.gs += 10;
            Destroy(gameObject);
            
        }

        if (collision.gameObject.tag == "base")
        {
            espeed += k;
            player.Damage();
            Destroy(gameObject);
            

        }

        if (collision.gameObject.tag == "plr")
        {
            espeed += k;
            player.phealth -= 2;
            Destroy(gameObject);
            

        }
    }
}
