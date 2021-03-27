using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : Singleton<GameManager>
{
        public int _points;
   
    public void AddScore()
    {
       // UIManager.Instance.scoreText = _points.ToString();

        UIManager.Instance.scoreText.text = _points.ToString();
    }
   


    // Update is called once per frame
    void Update()
    {
        AddScore();
    }
}