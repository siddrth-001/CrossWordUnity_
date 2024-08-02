using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoonMove : MonoBehaviour
{
   public Transform target;    // the object to rotate around
   private int Count =0;
   public int speed;   // the speed of rotation

   
    [SerializeField] TextMeshProUGUI ScoreText;
   
    [SerializeField] static int CounterScore =0;

void Start()
 {
    CounterScore =0;
    if (target == null) 
    {
        target = this.gameObject.transform;
        Debug.Log ("Rotate around object is not specified");
    }
}

// Update is called once per frame
void Update () 
{
  Vector3 newPos = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,-1);
  transform.RotateAround(target.transform.position,target.transform.forward,speed * Time.deltaTime);
}


public void LeftClick()
{
    
    speed = 175;
   
}

public void RightClick()
{
   
    speed = -175;
}



    public void OnCollisionEnter(Collision Object)
    {
        if(Object.transform.tag == "rock")
        {
             CounterScore+=1;
             ScoreText.text = CounterScore.ToString();
             Destroy(Object.gameObject);
             Debug.Log(CounterScore);
        }
       
    }
}



