using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosswordGenerate : MonoBehaviour
{
    public GameObject[] CrosswordList;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
         counter = Random.Range(0, 5);
        CrosswordList[counter].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
