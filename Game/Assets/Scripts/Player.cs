using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // public Rigidbody projectile;
    public Transform spawnPoint;
    public Projectile projectile;

    
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Instantiate(projectile);
            Projectile newProjectile = Instantiate<Projectile>(projectile, spawnPoint.position, spawnPoint.rotation);
            // Destroy(newProjectile.gameObject, 5f);
            // Debug.Log("Test");

    
    //    }
      //  void FixedUpdate()
        {
     //       RaycastHit hit;

      //      Vector3 fwd = transform.TransformDirection(Vector3.forward);

       //     if (Physics.Raycast(transform.position, fwd, out hit, 10))
    //        {
   //             print(hit.collider.name);

   //             if (hit.collider.CompareTag("Target"))
  //              {
        //            hit.collider.GetComponent<Renderer>().material.color = Color.blue;
      //          }

            }
        }
    }
}

