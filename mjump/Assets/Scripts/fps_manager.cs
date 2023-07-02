using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class fps_manager : MonoBehaviour
{

    private float deltaTime = 0.0f;
    public Canvas FPS_error_canvas;
    [SerializeField] private float priv_ses_timer;
    public float fps;

    private void Start()
    {
        
        FPS_error_canvas.enabled = false;
    }

    private void Update()
    {

        priv_ses_timer += 1 * Time.deltaTime;

        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        fps = Mathf.RoundToInt(1.0f / deltaTime);

        if(fps < 15f && priv_ses_timer > 6f)
        {
            Time.timeScale = 0f;
            FPS_error_canvas.enabled = true;
        }
    }
}
