using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Krajnost : MonoBehaviour {
    public GameObject Skriveni;
    public GameObject Player;
    public GameObject PlayerT;
    public GameObject Para;
    public GameObject Prava;
    

	// Use this for initialization
	void Start () {
        Skriveni.GetComponent<Canvas>().enabled=false;
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")


        {
            
            Para.gameObject.SetActive(false);
            Player.gameObject.SetActive(false);
            Skriveni.GetComponent<Canvas>().enabled = true;
            Prava.gameObject.SetActive(false);
            PlayerT.gameObject.SetActive(false);
        }

        
        
    }


}

