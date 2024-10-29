using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] int damage;
    public int Damage { get { return damage; } set { damage = value; } }

    protected string owner;

    //abstract methods
    public abstract void OnHitWith(Character character);
    public abstract void Move();

    public void Init(int _damage, string _owner)
    {
        Damage = _damage;
        owner = _owner;
    }

    public int GetShootDirection() //to be modify
    {
        return 1;
    }

    private void OnTriggerEnter2D(Collider2D other) //add later
    {
        OnHitWith(other.GetComponent<Character>() );
       // Destroy( this.gameObject );
    }
}
