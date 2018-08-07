using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuKrajDrugog: MonoBehaviour
{
    
    public Button replayText;
    public Button continueText;


    // Use this for initialization

    void Start()
    {
        
        replayText = replayText.GetComponent<Button>();
        continueText = continueText.GetComponent<Button>();
       

    }


   

    public void Replayl()
    { SceneManager.LoadScene("ElmoIgraPlatforma2"); }

    public void Continue()
    { SceneManager.LoadScene("ElmoIgraPlatforma3"); }
}
    