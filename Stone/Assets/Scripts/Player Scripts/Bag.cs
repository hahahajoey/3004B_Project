using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isClose;
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject drop1;
    public GameObject drop2;
    public GameObject drop3;
    public GameObject drop4;

    void Start()
    {
        isClose = false;
        slot1.SetActive(isClose);
        slot2.SetActive(isClose);
        slot3.SetActive(isClose);
        slot4.SetActive(isClose);
        drop1.SetActive(isClose);
        drop2.SetActive(isClose);
        drop3.SetActive(isClose);
        drop4.SetActive(isClose);
    }
    public void OpenOrCloseBag()
    {
        if (isClose)
        {
            isClose = false;
        }
        else
        {
            isClose = true;
        }
        slot1.SetActive(isClose);
        slot2.SetActive(isClose);
        slot3.SetActive(isClose);
        slot4.SetActive(isClose);
        drop1.SetActive(isClose);
        drop2.SetActive(isClose);
        drop3.SetActive(isClose);
        drop4.SetActive(isClose);

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
