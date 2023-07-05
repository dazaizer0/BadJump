using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Volume_settings : MonoBehaviour
{
    public Slider volumeSlider;

    public AudioSource volumeSource1;
    public AudioSource volumeSource2;

    void Start()
    {
        if (volumeSlider != null)
            volumeSlider.value = PlayerPrefs.GetFloat("volume");
        else
            volumeSource1.volume = PlayerPrefs.GetFloat("volume");
            volumeSource2.volume = PlayerPrefs.GetFloat("volume");
    }

    void Update()
    {
        
        if(volumeSlider != null)
        {

            volumeSource1.volume = volumeSlider.value;
            volumeSource2.volume = volumeSlider.value;
        }
    }

    public void SaveVolume()
    {

        PlayerPrefs.SetFloat("volume", volumeSlider.value);
    }
}
