using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class attrackAstro : MonoBehaviour
{
    [SerializeField] GameObject[] gamePrefabs;
    public Transform SpawnPoint;
  
    // Start is called before the first frame update
    void Start()
    {
       Invoke("PointOne",1.0f);
       Invoke("SpawnNew", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnNew()
    {
         int randomIndex = Random.Range(0, gamePrefabs.Length);
         Instantiate(gamePrefabs[randomIndex], SpawnPoint.position, SpawnPoint.rotation);
         Invoke("SpawnNew", Random.Range(5,10));
    }

    public void PointOne()
    {
        int TimeOne =Random.Range(8,13);
        gameObject.transform.DOMove(new Vector3(SpawnPoint.position.x,24,0),TimeOne);
        Invoke("PointTwo",TimeOne);
    }
    public void PointTwo()
    {
        int TimeTwo =Random.Range(8,13);
        gameObject.transform.DOMove(new Vector3(SpawnPoint.position.x,-3,0),TimeTwo);
        Invoke("PointOne",TimeTwo);
    }
}
