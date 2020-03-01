using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void quit_function() 
    {
        Debug.Log("called quit");
        Application.Quit();
    }
}
