using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class end_point : MonoBehaviour
{

    public Canvas end_canva;
    public TextMeshProUGUI EText;
    public string etext;
    public bool get = false;
    public player_movement pm;
    public ParticleSystem check_effect;
    public bool effect_played = false;
    public player_stats player_stats;
    public string cat_name;

    void Start()
    {
        
        end_canva.enabled = false;
    }

    private void Update()
    {
        
        /*
        // kicia
        if(player_stats.kicia == 1 && cat_name == "kicia")
        {

            gameObject.SetActive(false);
        }
        else
        {

            gameObject.SetActive(true);
        }

        // pysia
        if (player_stats.pysia == 1 && cat_name == "pysia")
        {

            gameObject.SetActive(false);
        }
        else
        {

            gameObject.SetActive(true);
        }

        // gacus
        if (player_stats.gacus == 1 && cat_name == "gacus")
        {

            gameObject.SetActive(false);
        }
        else
        {

            gameObject.SetActive(true);
        }

        // marcin
        if (player_stats.marcin == 1 && cat_name == "marcin")
        {

            gameObject.SetActive(false);
        }
        else
        {

            gameObject.SetActive(true);
        }

        // kini
        if (player_stats.kini == 1 && cat_name == "kini")
        {

            gameObject.SetActive(false);
        }
        else
        {

            gameObject.SetActive(true);
        }
        */
    }

    public void close_end_canva()
    {

        player_stats.rb.position = player_stats.rb.position;
        end_canva.enabled = false;
        StartCoroutine(pm.velocity_zero_for1s());

        player_stats.rb.velocity = Vector2.zero;
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "player" && !get)
        {
            
            get = true;

            end_canva.enabled = true;
            player_movement.canJump = false;
            Time.timeScale = 0f;

            EText.text = etext.ToString();
            Time.timeScale = 0f;
            Debug.Log(Time.timeScale);

            player_stats.score += 6000 / player_stats.timer;

            if (effect_played != true)
                check_effect.Play();
                effect_played = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {

        if(other.tag == "player")
        {

            end_canva.enabled = false;
            StartCoroutine(pm.velocity_zero_for1s());

            EText.text = etext.ToString();
            Time.timeScale = 1f;
            Debug.Log(Time.timeScale);
        }
    }
}
