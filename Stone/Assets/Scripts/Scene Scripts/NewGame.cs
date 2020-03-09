using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public void SceneLoader()
    { 
        SceneManager.LoadScene("Level0");
        Time.timeScale = 0f;
    }
}
