using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSound : MonoBehaviour
{
    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        source.Play();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }

} 