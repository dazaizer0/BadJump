using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class pause_menu : MonoBehaviour
{
    
    public Canvas p_menu;
    public static bool p_menu_active = false;

    void Start()
    {

        p_menu_active = false;
    }

    void Update()
    {

        if(p_menu_active)
        {

            p_menu.enabled = true;
            Time.timeScale = 0f;
        }
        else
        {

            p_menu.enabled = false;
            Time.timeScale = 1f;
        }
        
        if(Input.GetKeyDown(KeyCode.Escape) && !p_menu_active)
        {

            p_menu_active = true;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && p_menu_active)
        {

            p_menu_active = false;
            player_stats.rb.velocity =Vector2.zero;
        }
    }

    public void p_menu_btn()
    {

        if(!p_menu_active)
        {

            p_menu_active = true;
        }
        else if(p_menu_active)
        {

            p_menu_active = false;
            player_stats.rb.velocity =Vector2.zero;
        }
    }
}
