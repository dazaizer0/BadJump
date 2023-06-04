using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class end : MonoBehaviour
{

    public TextMeshProUGUI end_text;
    public TextMeshProUGUI end_text_2;

    void Start()
    {
        
        end_text.enabled = false;
        end_text_2.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "player")
        {

            end_text.enabled = true;
            end_text_2.enabled = true;
        }
    }
}
