using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class actions : MonoBehaviour
{

    public static void restart_scene()
    {

        SceneManager.LoadScene(0);
    }

    public static void quit_game()
    {

        Application.Quit();
        Debug.Log("Quit");
    }
}
