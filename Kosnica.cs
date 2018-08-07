using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kosnica : MonoBehaviour
{
    public float cura;
    public bool curak;


    private Collider2D colara;
    private Animator anim;

    public LayerMask whatIsCurak;
    void Start()
    {
        colara = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        curak = Physics2D.IsTouchingLayers(colara, whatIsCurak);
        anim.SetBool("Curak", curak);
        if (curak)
        { anim.Play("Curak"); }
    }


}


