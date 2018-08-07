using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankScript : MonoBehaviour
{


    public float lifetime;
    
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
        Sound.PlaySound("elmoKosnica");
        other.gameObject.GetComponent<HeartsSistem>().TakeDamage(-1);
        other.gameObject.GetComponent<Hearts2Sistem>().TakeDamage(-1);
        Destroy(gameObject, lifetime);

      


    }

    
    }
