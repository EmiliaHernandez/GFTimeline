﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour {

    private Animator anim;

    void Start(){
        anim = GetComponent<Animator>();
    }

    void Update(){
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("iswalkingleft", true);
            anim.SetBool("iswalkingdown", false);
            anim.SetBool("iswalkingright", false);
            anim.SetBool("iswalkingup", false);
        }
        else
        {
            anim.SetBool("iswalkingleft", false);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("iswalkingright", true);
            anim.SetBool("iswalkingup", false);
            anim.SetBool("iswalkingleft", false);
            anim.SetBool("iswalkingdown", false);
        }
        else
        {
            anim.SetBool("iswalkingright", false);
        }

    }
}