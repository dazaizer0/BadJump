using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    Rigidbody2D rb;
    public static bool canJump;
    public GameObject Direction;
    public float jump_force;
    public Transform donotclick;

    [Header("Sprites")]
    public GameObject idle_mesh;
    public GameObject jump_mesh;


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
            
            if(Vector2.Distance(transform.position, Direction.transform.position) < 0.9f || Vector2.Distance(transform.position, Direction.transform.position) > 14f /*|| Direction.transform.position == donotclick.transform.position*/)
            {

                Debug.Log("no direction");
                Direction.SetActive(false);
            }
            else
            {

                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector3 playerPosition = transform.position;

                Vector2 direction = (mousePosition - playerPosition).normalized;
                rb.AddForce(direction * jump_force, ForceMode2D.Impulse);

                Direction.SetActive(false);
                canJump = false;
            }
        }

        if (rb.velocity.x < -1f)
        {


            Quaternion newRotation = Quaternion.Euler(0f, 0f, 0f);
            transform.rotation = newRotation;
        }
        else if (rb.velocity.x > 1f)
        {

            Quaternion newRotation = Quaternion.Euler(0f, 180f, 0f);
            transform.rotation = newRotation;
        }

        if(canJump)
        {

            idle_mesh.SetActive(true);
            jump_mesh.SetActive(false);
        }
        else if (!canJump)
        {

            idle_mesh.SetActive(false);
            jump_mesh.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "ground")
        {

            canJump = true;
        }

        if (other.tag == "jump_pad")
        {

            rb.AddForce(Vector2.up, ForceMode2D.Impulse);
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

    public IEnumerator velocity_zero_for1s()
    {

        yield return new WaitForSeconds(1f);
        Time.timeScale = 1f;
        canJump = true;
    }
}
