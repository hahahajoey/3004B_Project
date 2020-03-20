using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public void SceneLoader()
    {
        Save_and_load.Save();
        SceneManager.LoadScene("Level0");
    }
}
