using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    [SerializeField]
    public int phealth = 10;

    [SerializeField]
    KeyCode left;
    [SerializeField]
    KeyCode right;
    [SerializeField]
    KeyCode up;
    [SerializeField]
    KeyCode down;
    [SerializeField]
    public float speed;



    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Damage() {
        phealth = -1;
    }

    // Update is called once per frame
    void Update()
    {
      
        
        timer += Time.deltaTime;
        if (Input.GetKey(right))
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(left))
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        }


        if (Input.GetKey(up))
        {
            transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
        }
        if (Input.GetKey(down))
        {
            transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;
            
        }

        if (timer > 5)
        {
            timer = 0;
            speed -= 1;
            
        }
        if (speed > 40)
        {
            speed = 40;
        }

      
    }

}
