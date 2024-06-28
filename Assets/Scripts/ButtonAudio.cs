using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ButtonAudio : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    public void ReloadScene()
    {
        SceneManager.LoadScene("_CrossWord_");
    }

     public void ReloadSceneTwo()
    {
        SceneManager.LoadScene("_CrossWordTwo_");
    }
}
