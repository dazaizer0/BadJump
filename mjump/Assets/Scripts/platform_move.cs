using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_move : MonoBehaviour
{
    
    public bool active = false;
    public Vector2 target_position;
    Rigidbody2D rb;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if(active)
        {

            rb.position = Vector2.MoveTowards(transform.position, target_position, 9f * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "player")
        {

            active = true;
        }
    }
}
