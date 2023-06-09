using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ingame_actions : MonoBehaviour
{
    
    public static void quit_game()
    {

        Application.Quit();
        Debug.Log("Quit");

        PlayerPrefs.SetFloat("timer", player_stats.timer);
    }
}
