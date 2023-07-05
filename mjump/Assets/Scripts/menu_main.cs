using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class menu_main : MonoBehaviour
{

    public Canvas options;
    public Canvas help;

    void Start()
    {
        
        options.enabled = false;
        help.enabled = false;
    }

    void Update()
    {
        
    }

    public void options_enable()
    {

        if(options.enabled == false)
        {

            options.enabled = true;
        }
        else
        {

            options.enabled = false;
        }
    }

    public void help_enable()
    {

        if (help.enabled == false)
        {

            help.enabled = true;
        }
        else
        {

            help.enabled = false;
        }
    }

    public void screen()
    {

        Screen.fullScreen = !Screen.fullScreen;
    }

    public void delete_data()
    {

        PlayerPrefs.DeleteKey("aspp_x");
        PlayerPrefs.DeleteKey("aspp_y");
        PlayerPrefs.DeleteKey("aspp_z");

        PlayerPrefs.DeleteKey("timer");
        PlayerPrefs.DeleteKey("score");
    }
}
