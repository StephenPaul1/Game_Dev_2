﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTargets : MonoBehaviour
{
    public GameObject[] waypoints;
    int current = 0;
    public float speed;
    readonly float WPradius = 1;

      void Update()
    {
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
        {
            current++;
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }
}
