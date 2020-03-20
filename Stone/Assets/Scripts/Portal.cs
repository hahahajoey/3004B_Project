using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public PlayerControlScript player;
    public float nextx;
    public float nexty;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            float[] position = { nextx, nexty };
            Save_and_load.Save(player, position , 1);
            SceneLoader();
            Debug.Log("next level");
        }
    }

    public void SceneLoader()
    {
        PlayerState temp = Save_and_load.Loadinfo();
        string stringtemp = "level" + temp.level.ToString();
        SceneManager.LoadScene(stringtemp);
    }
}
