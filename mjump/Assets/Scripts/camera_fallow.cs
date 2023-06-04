using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_fallow : MonoBehaviour
{
    
    public Transform target;
    public Vector3 offset;
    public float smooth;

    void FixedUpdate()
    {
        

        transform.position = Vector3.MoveTowards(transform.position, target.position + offset, smooth);
    }
}
