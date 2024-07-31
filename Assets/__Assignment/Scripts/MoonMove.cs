using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoonMove : MonoBehaviour
{
   public Transform target;    // the object to rotate around
   private int Count =0;
   public int speed;   // the speed of rotation

void Start()
 {
    if (target == null) 
    {
        target = this.gameObject.transform;
        Debug.Log ("Rotate around object is not specified");
    }
}

// Update is called once per frame
void Update () 
{
transform.RotateAround(target.transform.position,target.transform.forward,speed * Time.deltaTime);
}


public void LeftClick()
{
    if(speed>0)
    {
        speed =0;
    }
    speed = speed -50;
    if(speed < -200)
    {
        speed =-200;
    }
}

public void RightClick()
{
    if(speed<0)
    {
        speed =0;
    }
    speed = speed +50;
    if(speed > 200)
    {
        speed =200;
    }
}
}



