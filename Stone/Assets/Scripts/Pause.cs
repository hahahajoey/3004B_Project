using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool Paused = true;

    public GameObject pauseUI;
    public GameObject AttackUI;
    public GameObject UpUI;
    public GameObject DownUI;
    public GameObject LeftUI;
    public GameObject RightUI;

    private void Start()
    {
        resume();
    }
    public void Click()
    {
        if (Paused) { resume(); }
        else { pause(); }
    }

    public void pause() 
    {
        pauseUI.SetActive(true);
        AttackUI.SetActive(false);
        UpUI.SetActive(false);
        DownUI.SetActive(false);
        LeftUI.SetActive(false);
        RightUI.SetActive(false);
        Time.timeScale = 0f;
        Paused = true;
    }

    public void resume() 
    {
        pauseUI.SetActive(false);
        AttackUI.SetActive(true);
        UpUI.SetActive(true);
        DownUI.SetActive(true);
        LeftUI.SetActive(true);
        RightUI.SetActive(true);
        Time.timeScale = 1f;
        Paused = false;
    }
}
