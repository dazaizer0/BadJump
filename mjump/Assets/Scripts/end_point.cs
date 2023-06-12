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


    void Start()
    {
        
        end_canva.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "player")
        {

            end_canva.enabled = true;
            EText.text = etext.ToString();
            Time.timeScale = 0f;
        }
    }
}
