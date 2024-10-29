using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] int health;
    public int Health { get { return health; } set { health = value; } }

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

    // Start is called before the first frame update
    void Start()
    {

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
        health -= damage;

        IsDead();

    }
}
