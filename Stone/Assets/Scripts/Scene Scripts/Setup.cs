using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setup : MonoBehaviour
{
    public void SceneLoader()
    { 
        SceneManager.LoadScene("OptionScene"); 
    }
}