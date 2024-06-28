using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewRandomTextGen : MonoBehaviour
{
    List<string> RandWord=new List<string>{"A","B","C","D","E","F","G","H","I","J","H","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
    private int num,counter=0;
    public static bool _isParrot,_isLion,_isNest,_isTiger,_isRoar,_isApple = false;

    private static string _TextChecker,_FixStringCheck ="";
     [SerializeField] private AudioClip ButtonClick;
    [SerializeField] private AudioSource Buttonplayer;

    [SerializeField] private GameObject FinalPanel;



    
    // Start is called before the first frame update
    void Start()
    {
        
        _TextChecker = "";
        _FixStringCheck = "";
        num = Random.Range(0, 26);

        StartCoroutine(newTextAllocator());
    }

    
    IEnumerator newTextAllocator()
    {
     yield return new WaitForSeconds(.1f);
     if(gameObject.tag != "crossword")
     {
        gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = RandWord[num];
        gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().fontSize = 60;
     }
     else
     {
        gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().fontSize = 60;
     }
    }

    public void CheckString()
    {
       ClickButton(); 
      _TextChecker=gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
        _FixStringCheck= _FixStringCheck+_TextChecker;
        Debug.Log("This Button Contains Length of Text : "+_TextChecker.Length);
        Debug.Log(_FixStringCheck);

        if(_FixStringCheck.Contains("P A  R   R    O     T      "))
     {
        _isParrot = true;
        Debug.Log("Yes_Parrot");
     }

     if(_FixStringCheck.Contains("L I  O   N    "))
     {
        _isLion = true;
        Debug.Log("Yes_Lion");
     }
     
     if(_FixStringCheck.Contains("A P  P   L    E     "))
     {
       _isApple = true;
       Debug.Log("Yes_Apple");
     }
     
     if(_FixStringCheck.Contains("N E  S   T    "))
     {
        _isNest = true;
        Debug.Log("Yes_Nest");
     }
     
     if(_FixStringCheck.Contains("R O  A   R    "))
     {
        _isRoar = true;
        Debug.Log("Yes_Roar");
     }
     
     if(_FixStringCheck.Contains("T I  G   E    R     "))
     {
        _isTiger = true;
        Debug.Log("Yes_Tiger");
     }
        
        
    if(_FixStringCheck.Contains("P A  R   R    O     T      "))
    {
        if(_FixStringCheck.Contains("L I  O   N    "))
        {
            if(_FixStringCheck.Contains("N E  S   T    "))
            {
                if(_FixStringCheck.Contains("A P  P   L    E     "))
                {
                    if(_FixStringCheck.Contains("R O  A   R    "))
                    {
                        if(_FixStringCheck.Contains("T I  G   E    R     "))
                        {
                            Debug.Log("YES-Done");
                            FinalPanel.SetActive(true);
                        }
                    }
                }
            }
        }
    }
      
    }

     public void ClickButton()
    {
      Buttonplayer.PlayOneShot(ButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
