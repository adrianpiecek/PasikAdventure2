using UnityEngine;
using System.Collections;

public class MovingEnemy : MonoBehaviour
{
    public Transform[] Waypoints;
    public float moveSpeed = 3;
    public float rotateSpeed = 0.5f;
    public float scaleSpeed = 0.5f;
    public int CurrentPoint = 0;

    void Start()
    {
  
    }

    void FixedUpdate()
    {
        if (transform.position != Waypoints[CurrentPoint].transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, Waypoints[CurrentPoint].transform.position, moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, Waypoints[CurrentPoint].transform.rotation, rotateSpeed * Time.deltaTime);
            transform.localScale = Vector3.Lerp(transform.localScale, Waypoints[CurrentPoint].transform.localScale, scaleSpeed * Time.deltaTime);
        }

        if (transform.position == Waypoints[CurrentPoint].transform.position)
        {

            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;

            CurrentPoint += 1;
        }
        if (CurrentPoint >= Waypoints.Length)
        {

 

            CurrentPoint = 0;
        }
    }
}