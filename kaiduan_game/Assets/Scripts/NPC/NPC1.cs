using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1 : NPCbase
{//СŮ��������֮���������黵��֮��Ͳ������㽻��,�����˾ͻ�������1
    private void OnTriggerEnter(Collider other)
    {
        uiManager.uiChat.bt1.onClick.AddListener(OnButton1Click);
        uiManager.uiChat.bt2.onClick.AddListener(OnButton2Click);
        uiManager.uiChat.bt3.onClick.AddListener(OnButton3Click);
        //TODO��ʾ��E
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            checkPlayerWantToCommunicate();
            GSI.MinusChances();
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        uiManager.uiChat.HideWithCanvasGroup();
        //uiManager.uiChat.bt1.
    }

    #region ��Ӱ�����Ӧ
    void OnButton1Click()
    {
        base.moodLevelMinus();
    }
    void OnButton2Click()
    {
        base.moodLevelPlus();
    }
    void OnButton3Click()
    {
        uiManager.uiChat.ChangeChatText("���˺���");
    }
    #endregion

    #region ����
    public override void badMood()
    {
        //Debug.Log("�Է����ں�����");
        canCommunicate = false;
    }
    public override void goodMood()
    {
        //Debug.Log("�Է����ںܿ���");
        giveKey = true;
        //canCommunicate = true;
        //player.isGetItem1 = true;
    }
    #endregion
}
