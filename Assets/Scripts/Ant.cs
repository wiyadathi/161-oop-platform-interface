using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy
{
    [SerializeField] Vector2 velocity; //for ant movement
    public Vector2 Velocity { get { return velocity; } set { velocity = value; } }

    [SerializeField] Transform[] movePoints; //array to store 2 points (boundary) of ant movement
    
    // Start is called before the first frame update
    void Start()
    {
        Init(20);
        velocity = new Vector2 (-1.0f, 0.0f);
        DamageHit = 20;
    }

    void FixedUpdate()
    {
        Behavior();
    }

    public override void Behavior()
    {
        //move to new position (current position + vt)
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        //check if ตำแหน่งใหม่ เกินขอบซ้ายและขวา ของขอบเขตการเดินของมดหรือไม่ ถ้าใช่ สลับเดินอีกข้าง
        if (rb.position.x <= movePoints[0].position.x && velocity.x < 0)
        {
            Flip();
        }

        if (rb.position.x >= movePoints[1].position.x && velocity.x > 0)
        {
            Flip();
        }

    }

    /// <summary>
    /// กลับค่าความเร็วในแนวแกน x จากบวกเป็นลบ และ ลบเป็นบวก
    /// </summary>
    void Flip() 
    {
        //กลับทิศทางในการเคลื่อนที่ จากลบเป็นบวก 
        velocity.x *= -1;

        //กลับข้างจากซ้ายไปขวา
        Vector3 charScale = transform.localScale;
        charScale.x *= -1;
        transform.localScale = charScale;
    }


}
