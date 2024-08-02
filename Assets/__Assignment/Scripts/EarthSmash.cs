using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EarthSmash : MonoBehaviour
{
    [SerializeField] private GameObject gameBtnPanel,Overpanel,MoonSat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    
    public void OnCollisionEnter(Collision Object)
    {
        if(Object.transform.tag == "rock")
        {  
         MoonSat.SetActive(false);   
         gameBtnPanel.SetActive(false);
         Overpanel.SetActive(true); 
        }
       
    }


    public void EndGame()
    {
        Application.Quit();
    }


    public void ReloadScence()
    {
            string currentScene = SceneManager.GetActiveScene ().name; 
			Debug.Log (currentScene); 
			SceneManager.LoadScene(currentScene);
    }
}
