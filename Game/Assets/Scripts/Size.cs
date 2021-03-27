using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour
{
    public Difficulty Difficulty;
   
    void Update()
    {


        if (Difficulty == Difficulty.Easy)
        {

            {
                float scaleFactor = 5;
                transform.localScale = Vector3.one * scaleFactor;
                GetComponent<Renderer>().material.color = Color.red;


            }
        }

        if (Difficulty == Difficulty.Medium)
        {
            {
                float scaleFactor = 2;
                transform.localScale = Vector3.one * scaleFactor;
                GetComponent<Renderer>().material.color = Color.yellow;
            }
        }

        if (Difficulty == Difficulty.Hard)
        {

            {
                float scaleFactor = 1;
                transform.localScale = Vector3.one * scaleFactor;
                GetComponent<Renderer>().material.color = Color.green;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.collider.GetComponent<Renderer>().material.color = Color.red;
         Destroy(collision.collider.gameObject, 1f);
           Destroy(this.gameObject);
    }
}
       
