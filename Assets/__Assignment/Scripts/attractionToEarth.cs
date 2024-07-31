using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class attractionToEarth : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        int RR =Random.Range(12,18);
        gameObject.transform.DOMove(new Vector3(0, 3.5f,0),RR);
        Debug.Log(RR);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
