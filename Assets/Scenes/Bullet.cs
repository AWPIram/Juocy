using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float timer;

   


    public static float bspeed;
    // Start is called before the first frame update
    void Start()
    {
        if (bspeed < 1)
        {
            bspeed = 1;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        print(bspeed);
        timer += Time.deltaTime;

        transform.position += new Vector3(0, bspeed, 0) *Time.deltaTime;
        if (timer > 5 && bspeed > 0)
        {
            timer = 0;
            bspeed -= 1;
            if (bspeed < 0)
            {
                bspeed = 0;
            }

        }
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (true)
        {
            Destroy(gameObject);
        }
    }
}
