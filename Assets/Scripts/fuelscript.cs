using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelscript : MonoBehaviour
{
    
    float fuelamount;

    float fuelspawny;
    float fuelspawnx;


    [SerializeField]
    private GameObject fuel;
    float timer;
    [SerializeField]
    float speed;

    player1 player;

    GameObject newFuel;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<player1>();
    }

    // Update is called once per frame
    void Update()
    {
        fuelamount = Random.Range(10, 3);
        fuelspawny = Random.Range(-10, 0);
        fuelspawnx = Random.Range(-30, 30);
        timer += Time.deltaTime;
       

        

        if(timer > 10)
        {
            
            if (newFuel != null)
            {
                Destroy(newFuel);
            }
            timer = 0;
            newFuel = Instantiate(fuel, new Vector3(fuelspawnx, fuelspawny, 0), fuel.transform.rotation);
            newFuel.transform.parent = gameObject.transform;
        }
        

    }

    public void GiveFuel()
    {
        player.speed += fuelamount;
        Bullet.bspeed += fuelamount;
        
        Destroy(newFuel);

    }

    
}
