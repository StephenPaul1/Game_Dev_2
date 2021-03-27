using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGen : MonoBehaviour
{

    public GameObject[] objects;
    public int objNum;
    public int objCount = 0;

    void Update()
    {
        if (Input.GetButtonDown("Ikey"))
        {
            objNum = Random.Range(0, 4);
            objCount = 0;
            while (objCount < 4)
            {
               objects[objCount].SetActive(false);
                objCount += 1;
            }
            objects[objNum].SetActive(true);
        }
    }
}
