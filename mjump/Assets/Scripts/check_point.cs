using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_point : MonoBehaviour
{

    public bool activated = false;

    public float startValue = 1f; // startowa wartosc
    public float endValue = 2f; // wartosc konczaca
    public float lerpTime = 2f; // ile trwac ma

    private float currentTime = 0f;

    public ParticleSystem check_effect;
    public bool effect_played = false;

    public AudioSource audio_player;
    public AudioClip audio;

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
            if(effect_played != true)
            {
                check_effect.Play();
                effect_played = true;
                audio_player.clip = audio;
                audio_player.Play();
            }
        }
    }
}
