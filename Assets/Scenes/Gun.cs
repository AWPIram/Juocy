using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gun : MonoBehaviour
{

    float timer;
    
    

    [SerializeField]
    private GameObject bullet;
    float direction;
    float ab;
    bool lazer;
    bool freeze;
    public object Yield 
    { 
        get; private set; 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;
        
        if (lazer == true)
        {
            if (Looking == true)
            {
                direction = 1.5f;
            }
            if (Looking == false)
            {
                direction -= 1.5f;
            }
        }
        if (freeze == true)
        {

          
            
        }


        if (Input.GetKey(KeyCode.Space) && timer > 0.25f)
        {
            timer = 0;
            Instantiate(bullet, transform.position + new Vector3(direction, ab, 0), bullet.transform.rotation);


        }
    }
}
