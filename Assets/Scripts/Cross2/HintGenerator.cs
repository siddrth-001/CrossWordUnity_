using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintGenerator : MonoBehaviour
{
    [SerializeField] private GameObject hintApple;
    [SerializeField] private GameObject hintLion;

    [SerializeField] private GameObject hintNest;

    [SerializeField] private GameObject hintTiger;

    [SerializeField] private GameObject hintRoar;

    [SerializeField] private GameObject hintParrot;


    // Start is called before the first frame update
    void Start()
    {
        hintApple.SetActive(true);
        hintLion.SetActive(true);
        hintNest.SetActive(true);
        hintTiger.SetActive(true);
        hintRoar.SetActive(true);
        hintParrot.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
