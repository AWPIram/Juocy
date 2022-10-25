using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPscript : MonoBehaviour
{

    int hpamount;

    float healthspawny;
    float healthspawnx;


    [SerializeField]
    private GameObject health;
    float timer;
    [SerializeField]
    float speed;

    player1 player1;

    GameObject newHealth;
    // Start is called before the first frame update
    void Start()
    {
        player1 = FindObjectOfType<player1>();
        hpamount = 1;
    }

    // Update is called once per frame
    void Update()
    {
       
        healthspawny = Random.Range(-10, 0);
        healthspawnx = Random.Range(-30, 30);
        timer += Time.deltaTime;




        if (timer > 10)
        {

            if (newHealth != null)
            {
                Destroy(newHealth);
            }
            timer = 0;
            newHealth = Instantiate(health, new Vector3(healthspawnx, healthspawny, 0), health.transform.rotation);
            newHealth.transform.parent = gameObject.transform;
        }


    }

    public void GiveHealth()
    {
        player1.phealth += hpamount;

        Destroy(newHealth);

    }


}
