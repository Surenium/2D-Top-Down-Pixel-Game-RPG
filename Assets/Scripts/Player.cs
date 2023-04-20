using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Mover
{

    private bool isDash;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isDash = true;
        }
    }

    private void FixedUpdate()
    {
       
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        UpdateMotor(new Vector3(x, y, 0));

        if (isDash)
        {
          
        }
       
    }



    
}
