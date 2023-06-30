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


    void Start()
    {
        
        end_canva.enabled = false;
    }

    public void close_end_canva()
    {

        player_stats.rb.position = player_stats.rb.position;
        end_canva.enabled = false;
        player_stats.rb.velocity = Vector2.zero;
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "player" && !get)
        {
            
            get = true;

            end_canva.enabled = true;
            EText.text = etext.ToString();
            Time.timeScale = 0f;
            Debug.Log(Time.timeScale);

            player_stats.score += 6000 / player_stats.timer;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {

        if(other.tag == "player")
        {

            end_canva.enabled = false;
            EText.text = etext.ToString();
            Time.timeScale = 1f;
            Debug.Log(Time.timeScale);
        }
    }
}
