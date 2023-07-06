using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class menu_main : MonoBehaviour
{

    public Canvas options;
    public Canvas help;

    [SerializeField] private int kicia;
    [SerializeField] private int pysia;
    [SerializeField] private int gacus;
    [SerializeField] private int kini;
    [SerializeField] private int marcin;

    public Image Kicia_image;
    public Image Pysia_image;
    public Image Gacus_image;
    public Image Kini_image;
    public Image Marcin_image;

    void Start()
    {
        
        options.enabled = false;
        help.enabled = false;

        kicia = PlayerPrefs.GetInt("kicia");
        pysia = PlayerPrefs.GetInt("pysia");
        gacus = PlayerPrefs.GetInt("gacus");
        kini = PlayerPrefs.GetInt("kini");
        marcin = PlayerPrefs.GetInt("marcin");

        if(kicia == 1)
        {

            Kicia_image.enabled = true;
        }
        else
        {

            Kicia_image.enabled = false;
        }

        if (pysia == 1)
        {

            Pysia_image.enabled = true;
        }
        else
        {

            Pysia_image.enabled = false;
        }

        if (gacus == 1)
        {

            Gacus_image.enabled = true;
        }
        else
        {

            Gacus_image.enabled = false;
        }

        if (kini == 1)
        {

            Kini_image.enabled = true;
        }
        else
        {

            Kini_image.enabled = false;
        }

        if (marcin == 1)
        {

            Marcin_image.enabled = true;
        }
        else
        {

            Marcin_image.enabled = false;
        }
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

        PlayerPrefs.DeleteAll();
    }
}
