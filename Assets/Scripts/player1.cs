using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //all game over related code is written by Alex. rest is Iram.

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

    MeshRenderer mr;
    public Color blinkColor;
    Color origianlColor;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        origianlColor = mr.material.color;
    }

    public void Damage() {
        phealth -= 1;

        StartCoroutine(Blink());
        
    }

    IEnumerator Blink()
    {
        for (int i = 0; i < 6; i++)
        {
            print("Blink"); //Blinkar
            mr.material.color = blinkColor;
            yield return new WaitForSeconds(0.125f);
            print("blonk"); //Normal
            mr.material.color = origianlColor;
            yield return new WaitForSeconds(0.125f);
        }
        mr.material.color = origianlColor;
        print("blonk"); //Normal igen
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Damage();
        }
        
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
        if (phealth <= 0) // so basically this part is made by Alex.
        {
            SceneManager.LoadScene("GameOverScene");
        }
      
    }

}
