
using UnityEngine;

public class Target : MonoBehaviour
{

   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // if (collision.collider.CompareTag("Projectile"))
        {
            GetComponent<Renderer>().material.color = Color.red;
            Destroy(gameObject, 1f);
            Destroy(collision.gameObject);


        }


        // collision.collider.GetComponent<Renderer>().material.color = Color.red;
        //  Destroy(collision.collider.gameObject, 1f);
        //  Destroy(this.gameObject);
    }

    
        }


