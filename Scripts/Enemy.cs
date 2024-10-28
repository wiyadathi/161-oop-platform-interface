using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    int damageHit;
    public int DamageHit { get { return damageHit; } set { damageHit = value; } }

    //abstract method
    public abstract void Behavior();
}
