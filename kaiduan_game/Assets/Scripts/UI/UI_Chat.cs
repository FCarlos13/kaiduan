using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Chat : UIBase
{
    #region 组件
    Text text;

    //这三个按钮交付给用户自定义对应事件
    public Button bt1;
    public Button bt2;
    public Button bt3;
    #endregion


    public void HideAllButtons()
    {
        bt1.gameObject.GetComponent<UIBase>().HideWithCanvasGroup();
        bt2.gameObject.GetComponent<UIBase>().HideWithCanvasGroup();
        bt3.gameObject.GetComponent<UIBase>().HideWithCanvasGroup();
    }
    public void ResumeAllButton()
    {
        bt1.gameObject.GetComponent<UIBase>().ShowWithCanvasGroup();
        bt2.gameObject.GetComponent<UIBase>().ShowWithCanvasGroup();
        bt3.gameObject.GetComponent<UIBase>().ShowWithCanvasGroup();
    }
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
        HideWithCanvasGroup();
    }
}
