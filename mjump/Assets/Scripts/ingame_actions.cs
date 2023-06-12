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

    public static void play_game()
    {

        SceneManager.LoadScene("Game");
        Debug.Log("Play");
    }

    public static void menu_game()
    {

        SceneManager.LoadScene("Menu");
        Debug.Log("mMenu");

        PlayerPrefs.SetFloat("timer", player_stats.timer);
    }
}
