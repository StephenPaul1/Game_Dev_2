using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody rbody;

    void Start()
    {
        rbody.AddForce(rbody.transform.forward * speed, ForceMode.Impulse);
        Destroy(gameObject, 1f);
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
            if (hit.collider.CompareTag("Enemy"))
            {
                hit.collider.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}