using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;

    float timer;
    float pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = Random.Range(-30, 30);
        timer += Time.deltaTime;



        if ( timer > 4)
        {
            timer = 0;
            Instantiate(enemy, new Vector3(pos, 10, 0), enemy.transform.rotation);

        }
    }
}
