using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]

public class ZaAnimaciju : MonoBehaviour
{
    public MovieTexture movie;
    private AudioSource audio;
    float TmStart;
    float TmLen = 41f;


    // Use this for initialization
    void Start()
    {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        audio = GetComponent<AudioSource>();
        audio.clip = movie.audioClip;
        movie.Play();
        audio.Play();
        TmStart = Time.time;

    }

    void Update()
    {
        if (Time.time > TmStart + TmLen)
        {
            SceneManager.LoadScene("ElmoIgraPlatforma");

        }

    }
}

