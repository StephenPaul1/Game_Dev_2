using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Singleton<Enemy>
{
    public int health;
    public Animator anim;
    

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
         TakeDamage(10);           
        }


    }
    public void TakeDamage(int _damage)
        {
        
        anim.SetTrigger("Hit");
            health -= _damage;
        GameManager.Instance._points += 10;
            if (health <= 5)
                Die();
        
    }
        public void Die()
        {
            anim.SetTrigger("Death");
        GameManager.Instance._points += 100;
            EnemyManager.Instance.EnemyKilled(gameObject);
           StopAllCoroutines();
            Destroy(this.gameObject);

        }

    }


