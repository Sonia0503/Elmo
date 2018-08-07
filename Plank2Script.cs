using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plank2Script:MonoBehaviour
{

    int damage = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        other.gameObject.GetComponent<HeartsSistem>().TakeDamage(1);
        other.gameObject.GetComponent<Hearts2Sistem>().TakeDamage(1);
        Sound.PlaySound("elmoOuch");
    }

    
}

