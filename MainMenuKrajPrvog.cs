using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuKrajPrvog : MonoBehaviour
{
    
    public Button replayText;
    public Button continueText;


    // Use this for initialization

    void Start()
    {
        
        replayText = replayText.GetComponent<Button>();
        continueText = continueText.GetComponent<Button>();
       

    }


   

    public void Replay()
    { SceneManager.LoadScene("ElmoIgraPlatforma"); }

    public void Continue()
    { SceneManager.LoadScene("ElmoIgraPlatforma2"); }
}
    