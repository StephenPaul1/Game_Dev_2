using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody rbody;


    // Start is called before the first frame update
    void Start()
    {
        rbody.AddForce(rbody.transform.forward * speed, ForceMode.Impulse);
        Destroy(gameObject, 1f);
    }

    // Update is called once per frame
    void Update()
    {
    
    
    }

    void FixedUpdate()
    {
        RaycastHit hit;

        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, 10))
        {
            print(hit.collider.name);

            if (hit.collider.CompareTag("Target"))
            {
                hit.collider.GetComponent<Renderer>().material.color = Color.blue;
            }
        }
    }
}