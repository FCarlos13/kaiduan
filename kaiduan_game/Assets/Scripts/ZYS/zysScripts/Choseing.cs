using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choseing : MonoBehaviour
{
    public GameObject ChoseUI;
    public GameObject EventUI1;
    public GameObject EventUI2;
    public GameObject EventUI3;
    public GameObject EventUI4;
    public bool Check = true;
    void Update()
    {
        if (Check && Input.GetKeyDown("1"))
        {
            ChoseUI.SetActive(false);
            EventUI1.SetActive(true);
            Check = false;
        }
        else if (Check && Input.GetKeyDown("2"))
        {
            ChoseUI.SetActive(false);
            EventUI2.SetActive(true);
            Check = false;
        }
        else if (Check && Input.GetKeyDown("3"))
        {
            ChoseUI.SetActive(false);
            EventUI3.SetActive(true);
            Check = false;
        }
        else if (Check && Input.GetKeyDown("4"))
        {
            ChoseUI.SetActive(false);
            EventUI4.SetActive(true);
            Check = false;
        }
        if(Check==false && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("按下了E，销毁对话");
            Destroy(EventUI1);
            Destroy(EventUI2);
            Destroy(EventUI3);
            Destroy(EventUI4);
        }
    }
}
