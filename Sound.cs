using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public static AudioClip kosnicaSound,ouchSound;
    static AudioSource audioSrc;

    // Use this for initialization
    void Start()
    {
        kosnicaSound = Resources.Load<AudioClip>("elmoKosnica");
        ouchSound = Resources.Load<AudioClip>("elmoOuch");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "elmoKosnica":
                audioSrc.PlayOneShot(kosnicaSound);
                break;

            case "elmoOuch":
                audioSrc.PlayOneShot(ouchSound);
                break;
        
        }
    }
}
