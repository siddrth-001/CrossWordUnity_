using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class RandomTextGenerator : MonoBehaviour
{
    List<string> RandWord=new List<string>{"A","B","C","D","E","F","G","H","I","J","H","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
    private int num=0;
    // List<string> emptyList = new List<string>();
    private  List<string> CrossCheck = new List<string>{"PARROT","APPLE","LION","NEST","TIGER","ROAR"};
    private static string TextCheck,FixCheck = "";
    
    [SerializeField] private GameObject _ParrotStrip;
    [SerializeField] private GameObject _LionStrip;
    [SerializeField] private GameObject _TigerStrip;
    [SerializeField] private GameObject _RoarStrip;
    [SerializeField] private GameObject _AppleStrip;
    [SerializeField] private GameObject _NestStrip;
    
    [SerializeField] private AudioClip ButtonClick;
    [SerializeField] private AudioSource Buttonplayer;
    
 
    void Start()
    { 
        TextCheck= "";
        FixCheck = "";
     num = Random.Range(0, 26);   
     StartCoroutine(TextAllocator());
    }

    IEnumerator TextAllocator()
    {
     yield return new WaitForSeconds(.1f);
     if(gameObject.tag != "crossword")
     {
        gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = RandWord[num];
        gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().fontSize = 70;
     }
     else
     {
        gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().fontSize = 70;
     }
    }


    public void TaskOnClick()
    {
      ClickButton();
      TextCheck=gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
      FixCheck= FixCheck+TextCheck;
      Debug.Log(FixCheck);

      #region Raw

     if(FixCheck.Contains("PARROT"))
     {
        _ParrotStrip.SetActive(false);
     }

     if(FixCheck.Contains("LION"))
     {
        _LionStrip.SetActive(false);
     }
     
     if(FixCheck.Contains("APPLE"))
     {
       _AppleStrip.SetActive(false);
     }
     
     if(FixCheck.Contains("NEST"))
     {
        _NestStrip.SetActive(false);
     }
     
     if(FixCheck.Contains("ROAR"))
     {
        _RoarStrip.SetActive(false);
     }
     
     if(FixCheck.Contains("TIGER"))
     {
        _TigerStrip.SetActive(false);
     }
     
    //   if(FixCheck.Length>3)
    //   {
    //     for(int i=0;i<CrossCheck.Count;i++)
    //     {
    //         if(FixCheck.Contains(CrossCheck[i]))
    //         {
    //             // if(!emptyList.Contains(CrossCheck[i]))
    //             // {
    //             //     emptyList.Add(CrossCheck[i]);
    //             //     Debug.Log(string.Join(",", emptyList));
    //             // }
    //             CrossCheck.Remove(CrossCheck[i]);

    //             Count+=1;
    //             FixCheck="";
    //         }
    //     }

    
    //   }

#endregion Raw

    if(FixCheck.Contains("PARROT"))
    {
        if(FixCheck.Contains("LION"))
        {
            if(FixCheck.Contains("NEST"))
            {
                if(FixCheck.Contains("APPLE"))
                {
                    if(FixCheck.Contains("ROAR"))
                    {
                        if(FixCheck.Contains("TIGER"))
                        {
                            Debug.Log("YES-Done");
                        }
                    }
                }
            }
        }
    }
      
       
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    

     public void ClickButton()
    {
      Buttonplayer.PlayOneShot(ButtonClick);
    }

}
