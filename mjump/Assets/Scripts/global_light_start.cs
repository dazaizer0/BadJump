using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class global_light_start : MonoBehaviour
{

    public Light2D light2d;

    void Start()
    {

        light2d.intensity = 0f;
    }
}
