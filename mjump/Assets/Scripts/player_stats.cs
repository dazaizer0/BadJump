using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class player_stats : MonoBehaviour
{   

    [Header("aspp_manager")]
    public Vector3 actual_spawnpoint_position;
    public bool check_pointed = false;

    public static float score;
    public TextMeshProUGUI Score;

    public TextMeshProUGUI Timer;
    public static float timer;
    public static Rigidbody2D rb;

    public Canvas end_canva;

    public int kicia;
    public int pysia;
    public int gacus;
    public int kini;
    public int marcin;

    void Start()
    {
        
        timer = PlayerPrefs.GetFloat("timer");
        score = PlayerPrefs.GetFloat("score");

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

            delete_data();
        }

        if(Input.GetKeyDown(KeyCode.R))
        {

            restart_scene();
            player_movement.canJump = true;
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {

            ingame_actions.quit_game();
        }

        timer += 1 * Time.deltaTime;
        Timer.text = timer.ToString("F1");
        Score.text = "score: " + score.ToString("F2");
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

        if (other.name == "end_kicia")
        {

            kicia = 1;
            PlayerPrefs.SetInt("kicia", kicia);
        }
        if (other.name == "end_pysia")
        {

            pysia = 1;
            PlayerPrefs.SetInt("pysia", pysia);
        }
        if (other.name == "end_gacus")
        {

            gacus = 1;
            PlayerPrefs.SetInt("gacus", gacus);
        }
        if (other.name == "end_kini")
        {

            kini = 1;
            PlayerPrefs.SetInt("kini", kini);
        }
        if (other.name == "end_marcin")
        {

            marcin = 1;
            PlayerPrefs.SetInt("marcin", marcin);
        }

        if (other.tag == "point")
        {

            check_pointed = true;
            actual_spawnpoint_position = other.transform.position;

            PlayerPrefs.SetFloat("aspp_x", actual_spawnpoint_position.x);
            PlayerPrefs.SetFloat("aspp_y", actual_spawnpoint_position.y);
            PlayerPrefs.SetFloat("aspp_z", actual_spawnpoint_position.z);

            if (other.gameObject.TryGetComponent(out check_point chp))
            {

                if(chp.activated == false)
                {

                    score += 60 / timer;
                }
            }
        }
    }

    public void restart_scene()
    {

        transform.position = actual_spawnpoint_position;

        rb.velocity = Vector2.zero;

        pause_menu.p_menu_active = false;
        end_canva.enabled = false;

        Time.timeScale = 1f;
    }

    public void delete_data()
    {

        PlayerPrefs.DeleteAll();
    }
}
