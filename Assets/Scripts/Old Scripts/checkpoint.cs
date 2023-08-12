﻿using UnityEngine;
using System.Collections;

public class checkpoint : MonoBehaviour
{

    public enum state {Inactive,Active,Used,Locked};

    public state status;

    public checkpointHandler ch;

    public Sprite[] sprites;

    Animator m_Animator;

    void Start()
    {

        m_Animator = gameObject.GetComponent<Animator>();

        ch = GameObject.Find("checkpointHandler").GetComponent<checkpointHandler>();

    }

    void Update()
    {
        ChangeColor ();
    }


    // Update is called once per frame
    void ChangeColor()
    {

        if (status == state.Inactive)
        {
            GetComponent<SpriteRenderer>().sprite = sprites[0];
        }
        else if (status == state.Active)
        {
            GetComponent<SpriteRenderer>().sprite = sprites[1];
        }
        else if (status == state.Used)
        {
            GetComponent<SpriteRenderer>().sprite = sprites[2];
        }
        else if (status == state.Locked)
        {
            GetComponent<SpriteRenderer>().sprite = sprites[3];
        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {

            m_Animator.SetTrigger("kolizja");

            ch.UpdateCheckpoints(this.gameObject);
            {

            }
        }
    }


}