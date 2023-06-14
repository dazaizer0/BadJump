using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class menu_main : MonoBehaviour
{

    public Canvas options;

    void Start()
    {
        
        options.enabled = false;
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

    public void delete_data()
    {

        PlayerPrefs.DeleteKey("aspp_x");
        PlayerPrefs.DeleteKey("aspp_y");
        PlayerPrefs.DeleteKey("aspp_z");

        PlayerPrefs.DeleteKey("timer");
        PlayerPrefs.DeleteKey("score");
    }
}
