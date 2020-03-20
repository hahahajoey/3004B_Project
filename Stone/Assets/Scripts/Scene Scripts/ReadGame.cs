using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadGame : MonoBehaviour
{
    public void SceneLoader()
    {
        PlayerState temp = Save_and_load.Loadinfo();
        string stringtemp = "level" + temp.level.ToString();
        SceneManager.LoadScene(stringtemp);
    }
}
