using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform spawnPoint;
    public Projectile projectile;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectile);
            Projectile newProjectile = Instantiate<Projectile>(projectile, spawnPoint.position, spawnPoint.rotation);
             Destroy(newProjectile.gameObject, 5f);
             Debug.Log("Test");

            }
        }
    }


