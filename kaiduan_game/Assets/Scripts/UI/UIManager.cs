using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    /// <summary>
    /// �ṩһ�����������ӿ�
    /// </summary>

    #region �������
    GameSystemInterfaces sysCtrl;

    //�ṩ���ⲿϵͳ����UI���
    public UI_Chances uiChances;
    public UI_Chat uiChat;
    public UI_Item uiItem;
    public UI_Die uiDie;
    #endregion

    #region �ӿں��� //TODO
    //ʣ�����=========================================================
    public void ChangeChances(int i)
    {
        uiChances.ChangeNum(i);
    }
    //����=============================================================
    public void ShowChat()
    {
        uiChat.ShowWithCanvasGroup();
    }
    public void HideChat()
    {
        uiChat.HideWithCanvasGroup();
    }
    public void PlayWords(string s)
    {
        uiChat.ChangeChatText(s);
    }
    //public ref Button GetButton(int i)
    //{
    //    switch(i)
    //    {
    //        case 1:
    //            return ref uiChat.bt1;
    //        case 2:
    //            return ref uiChat.bt2;
    //        case 3:
    //            return ref uiChat.bt3;
    //        default:
    //            return;
    //    }
    //}

    //������===========================================================
    //����ҳ��=========================================================


    #endregion


    #region �ص�
    void Start()
    {
        sysCtrl = GameObject.Find("SystemControl").GetComponent<GameSystemInterfaces>();
        uiChances = transform.Find("Cover/div_Chances").gameObject.GetComponent<UI_Chances>();
        uiChat = transform.Find("Cover/div_Chat").gameObject.GetComponent<UI_Chat>();
        uiItem = transform.Find("Cover/div_Item").gameObject.GetComponent<UI_Item>();
        uiDie = transform.Find("Cover/div_Die").gameObject.GetComponent<UI_Die>();
        sysCtrl.AllignGSComponent(this);
    }
    void Update()
    {
        ChangeChances(sysCtrl.GetChancesNum());
    }
    #endregion
}
