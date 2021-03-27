
using UnityEngine;

public class Target : MonoBehaviour
{

    public TargetSize TargetSize;


  //  SWITCH STATEMENT
    
     
        //  switch (TargetSize)
        //   {
        //     case TargetSize.Small:
        //         {

        //             float scaleFactor = 2;
        //             transform.localScale = Vector3.one * scaleFactor;
        //          }
        //          break;

        //    case TargetSize.Medium:

        //      {
        //           float scaleFactor = 1;
        //            transform.localScale = Vector3.one * scaleFactor;

        //       }
        //      break;

        //     case TargetSize.Large:
        //     {
        //          float scaleFactor = 0.5f;
        //          transform.localScale = Vector3.one * scaleFactor;
        //     }
        //    break;
        //   }

    void Update()
    {
        if (TargetSize == TargetSize.Small)
        {

            {
                float scaleFactor = 2;
                transform.localScale = Vector3.one * scaleFactor;
                GetComponent<Renderer>().material.color = Color.red;


            }
        }

        if (TargetSize == TargetSize.Medium)
        {
            {
                float scaleFactor = 1;
                transform.localScale = Vector3.one * scaleFactor;
                GetComponent<Renderer>().material.color = Color.yellow;
            }
        }

        if (TargetSize == TargetSize.Large)
        {

            {
                float scaleFactor = 0.5f;
                transform.localScale = Vector3.one * scaleFactor;
                GetComponent<Renderer>().material.color = Color.green;
            }
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
       
        {
            GameManager.Instance._points += 100;
            GetComponent<Renderer>().material.color = Color.red;
            Destroy(gameObject, 3f);
            Destroy(collision.gameObject);
            
        }
        
    }
}


