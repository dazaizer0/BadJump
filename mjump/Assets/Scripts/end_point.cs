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



    void Start()
    {
        
        end_canva.enabled = false;
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
