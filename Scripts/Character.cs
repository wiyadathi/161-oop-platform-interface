using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    int health;
    public int Health {  get { return health; } set { health = value; } }
    
    public Animator animator;
    public Rigidbody2D rb;
    
    //constructor-like in unity
    public virtual void Init(int newHealth)
    {
        health = newHealth;
        //get components for prefabs
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsDead()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        else return false;

    }

    public void TakeDamage(int damage)
    {
        health -= damage; ;
        IsDead();
    }
}
