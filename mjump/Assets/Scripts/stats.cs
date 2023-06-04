using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class stats : MonoBehaviour
{   

    [Header("aspp_manager")]
    public Vector3 actual_spawnpoint_position;
    public bool check_pointed = false;

    void Start()
    {
        
        actual_spawnpoint_position.x = PlayerPrefs.GetFloat("aspp_x");
        actual_spawnpoint_position.y = PlayerPrefs.GetFloat("aspp_y");
        actual_spawnpoint_position.z = PlayerPrefs.GetFloat("aspp_z");

        transform.position = actual_spawnpoint_position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "damage")
        {
            
            if(check_pointed)
            {

                transform.position = actual_spawnpoint_position;
            }
            else
            {

                SceneManager.LoadScene(0);
            }
        }
        
        if(other.tag == "point")
        {

            check_pointed = true;
            actual_spawnpoint_position = other.transform.position;

            PlayerPrefs.SetFloat("aspp_x", actual_spawnpoint_position.x);
            PlayerPrefs.SetFloat("aspp_y", actual_spawnpoint_position.y);
            PlayerPrefs.SetFloat("aspp_z", actual_spawnpoint_position.z);
        }
    }
}
