using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC3 : NPCbase
{//���ף�����ֵ����ʱҲԸ����㽻��������֮�����ڱ���ҪNPC1���ڸ���״̬��ͬʱ��������ֵҲҪ���˲Ż�������3
    #region ��Ӱ�����Ӧ
    public override void OnButton1Click()
    {
        base.moodLevelMinus();
        if (moodLevel <= 0) badMood();
    }
    public override void OnButton2Click()
    {
        base.moodLevelPlus();
        if (moodLevel >= 20) goodMood();
    }
    public override void OnButton3Click()
    {
        uiManager.uiChat.HideWithCanvasGroup();
        if (!GameObject.Find("CM FreeLook1"))
        {
            MainCamera.SetActive(true);
        }
    }
    #endregion

    #region ����
    public override void badMood()
    {
        //Debug.Log(GameObject.Find("MainCanvas"));
        canCommunicate = false;
        uiManager.uiChat.ChangeChatText("��÷������������˵����");
        uiManager.uiChat.HideAllButtons();
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
