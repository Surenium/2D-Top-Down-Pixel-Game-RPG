using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Collidable
{
    //Damage Struct
    public int damagePoint = 1;
    public float pushForce = 2.0f;

    //Upgrade
    private SpriteRenderer spriteRenderer;


    //Swing
    private float cooldown = 0.5f;
    private float lastSwing;


    protected override void Start()
    {
        base.Start();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    protected override void Update()
    {
        base.Update();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(Time.time - lastSwing > cooldown)
            {
                lastSwing = Time.time;
                Swing();
            }
        }
    }


    private void Swing()
    {
        Debug.Log("Swing");
    }
}
