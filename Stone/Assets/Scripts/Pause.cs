using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool Paused = false;

    public GameObject pauseUI;

    public void Click()
    {
        if (Paused) { resume(); }
        else { pause(); }
    }

    public void pause() 
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }

    public void resume() 
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }
}
