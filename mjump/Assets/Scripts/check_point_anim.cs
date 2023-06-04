using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_point_anim : MonoBehaviour
{

    public bool activated = false;

    public float startValue = 0f; // startowa wartosc
    public float endValue = 1f; // wartosc konczaca
    public float lerpTime = 2f; // ile trwac ma

    private float currentTime = 0f;

    void Update ()
    {

        if(activated)
        {

            currentTime += Time.deltaTime;

            float t = Mathf.Clamp01(currentTime / lerpTime);
            float currentValue = Mathf.Lerp(startValue, endValue, t);
            transform.localScale = new Vector2(currentValue, currentValue);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "player")
        {

            activated = true;
        }
    }
}
