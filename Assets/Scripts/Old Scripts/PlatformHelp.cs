using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlatformHelp : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "platform")
        {
            this.transform.parent = other.transform;

        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "platform")
        {
            this.transform.parent = null;

        }
    }
}
