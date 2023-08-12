using UnityEngine;
using System.Collections;

public class Dead : MonoBehaviour
{

    public GameObject player;
    public GameObject spawn;
    public GameObject[] checkpoints;

   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "deadly")
        {
            foreach (GameObject cp in checkpoints)
        
            if (cp.GetComponent<checkpoint>().status == checkpoint.state.Active)
            {
                player.transform.position = cp.transform.position;
                return;
            }
        }

    }

}
