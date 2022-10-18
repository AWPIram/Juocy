using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelCanister : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "plr")
        {
            transform.parent.SendMessage("GiveFuel");

        }
        if (collision.gameObject.tag == "blt")
        {
            Destroy(gameObject);

        }
    }
}
