using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;


public class UIManager : Singleton<UIManager>
{

    public TMPro.TextMeshProUGUI scoreText;
    public int _points;
    

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance._points.ToString();
       
    }

    void Shake()
    {
        DOTween.Kill(transform);
        DOTween.Kill(scoreText.transform);
        transform.localScale = Vector3.one;
        transform.DOScale(10f, 2f).SetLoops(4, LoopType.Yoyo).SetDelay(1f).SetEase(Ease.OutBounce);
        scoreText.transform.DOPunchScale(Vector3.one * 1.015f, 2f, 10, 0.5f);

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Shake();
        }
    }
}
  




  
