using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossWordGenerator : MonoBehaviour
{
    private int Settler;                                           //TO STORE RANDOM GENERATED INTEGER VALUE 
    public GameObject[] AllCrossWords;                             //LIST OF GameObject TO STORE THE SET VALUES AND MADE THEIR SETACTIVE true
    // Start is called before the first frame update
    void Start()
    {
        Settler = Random.Range(0,12);       //To decide either any one of the Total 
        // Debug.Log(Settler);                // 0:- Horizontal,   1:- Vertical
        GenerateCrossWord();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateCrossWord()
    {
         for (int i = 0;i < AllCrossWords.Length;i++)
         {
            AllCrossWords[i].gameObject.SetActive(false);
         }
         AllCrossWords[Settler].gameObject.SetActive(true);
         
    }
}
