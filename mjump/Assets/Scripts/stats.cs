using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class stats : MonoBehaviour
{   

    [Header("aspp_manager")]
    public Vector3 actual_spawnpoint_position;
    public bool check_pointed = false;

    public TextMeshProUGUI Timer;
    public static float timer;
    public static Rigidbody2D rb;

    void Start()
    {
        
        timer = PlayerPrefs.GetFloat("timer");
        actual_spawnpoint_position.x = PlayerPrefs.GetFloat("aspp_x");
        actual_spawnpoint_position.y = PlayerPrefs.GetFloat("aspp_y");
        actual_spawnpoint_position.z = PlayerPrefs.GetFloat("aspp_z");

        transform.position = actual_spawnpoint_position;

        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Delete))
        {

            PlayerPrefs.DeleteKey("aspp_x");
            PlayerPrefs.DeleteKey("aspp_y");
            PlayerPrefs.DeleteKey("aspp_z");
            PlayerPrefs.DeleteKey("timer");

            SceneManager.LoadScene(0);
        }

        if(Input.GetKeyDown(KeyCode.R))
        {

            restart_scene();
            movement.canJump =  true;
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {

            actions.quit_game();
        }

        timer += 1 * Time.deltaTime;
        Timer.text =timer.ToString("F1");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "damage")
        {
            
            if(check_pointed)
            {

                transform.position = actual_spawnpoint_position;
            }
            else
            {
                transform.position = Vector2.zero;
            }
            
            rb.velocity = Vector2.zero;
        }
        
        if(other.tag == "point")
        {

            check_pointed = true;
            actual_spawnpoint_position = other.transform.position;

            PlayerPrefs.SetFloat("aspp_x", actual_spawnpoint_position.x);
            PlayerPrefs.SetFloat("aspp_y", actual_spawnpoint_position.y);
            PlayerPrefs.SetFloat("aspp_z", actual_spawnpoint_position.z);
        }
    }

    public void restart_scene()
    {

        transform.position = actual_spawnpoint_position;
        rb.velocity = Vector2.zero;
    }
}
