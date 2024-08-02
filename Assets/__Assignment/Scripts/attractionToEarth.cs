using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;


public class attractionToEarth : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        int RR =Random.Range(8,13);
        gameObject.transform.DOMove(new Vector3(0, 3.5f,-1),RR);

        Destroy(gameObject,15.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
