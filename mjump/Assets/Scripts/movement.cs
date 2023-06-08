using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rb;
    public static bool canJump;
    public GameObject Direction;
    public float jump_force;

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        Direction.SetActive(false);
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && canJump == true && !pause_menu.p_menu_active)
        {

            Direction.SetActive(true);
        }

        if (Input.GetMouseButtonUp(0) && canJump == true && !pause_menu.p_menu_active)
        {
            
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 playerPosition = transform.position;

            Vector2 direction = (mousePosition - playerPosition).normalized;
            rb.AddForce(direction * jump_force, ForceMode2D.Impulse);

            Direction.SetActive(false);
            canJump = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "ground")
        {

            canJump = true;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        
        if(other.tag == "ground")
        {

            canJump = true;
        }
    }

    void OnTriggerStay(Collider other)
    {
        
        if(other.tag == "ground")
        {

            canJump = true;
        }
    }
}
