using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Play : MonoBehaviour
{


    
    public Button PlayText;
    float TmStart;
    float TmLen = 8f;
    


    // Use this for initialization

    void Start()
    {
        TmStart = Time.time;
        
        

    }


    private void Update()
    {
        if (Time.time > TmStart + TmLen)
        {
            SceneManager.LoadScene("ElmoIgraPlatforma");
            
        }
        }



    
}

    