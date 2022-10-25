using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gun : MonoBehaviour
{

    float timerg;

    bool Looking;

    [SerializeField]
    private GameObject bullet;
    float direction;
    float ab = 3;
    bool lazer;
    
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
        
        timerg += Time.deltaTime;
        
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
       


        if (Input.GetKey(KeyCode.Space) && timerg > 0.25f)
        {
            
            Instantiate(bullet, transform.position + new Vector3(direction, ab, 0), bullet.transform.rotation);
            timerg = 0;

        }
    }
}
