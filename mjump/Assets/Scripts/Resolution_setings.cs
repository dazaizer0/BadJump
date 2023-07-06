using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Resolution_setings : MonoBehaviour
{

    public TMP_Dropdown resolution_dropdown;
    Resolution[] resolutions;

    private void Start()
    {
        
        resolutions = Screen.resolutions;

        resolution_dropdown.ClearOptions();

        List<string> options = new List<string>();

        int current_resolution_index = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {

            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {

                current_resolution_index = i;
            }
        }

        resolution_dropdown.AddOptions(options);
        resolution_dropdown.value = current_resolution_index;
        resolution_dropdown.RefreshShownValue();
    }

    public void SetResolution(int resolution_index)
    {

        Resolution resolution = resolutions[resolution_index];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
