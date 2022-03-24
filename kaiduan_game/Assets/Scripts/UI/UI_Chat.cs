using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Chat : UIBase
{
    Text text;
    public Button bt1;
    public Button bt2;
    public Button bt3;

    public void ChangeChatText(string s)
    {
        text.text = s;
    }
        
    private void Start()
    {
        text = transform.Find("Text").gameObject.GetComponent<Text>();
        bt1 = transform.Find("Choice1").gameObject.GetComponent<Button>();
        bt2 = transform.Find("Choice2").gameObject.GetComponent<Button>();
        bt3 = transform.Find("Choice3").gameObject.GetComponent<Button>();
        //HideWithCanvasGroup();
    }
}
