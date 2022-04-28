using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC2 : NPCbase
{//��ͨ�ˣ����黵��Ҳ�ܽ���������֮������һ������ֵ����-20���ͻᵼ��player����ɱ��������ֵ���˵�ʱ��,���һ�Ҫ�����˵���1�Ż�������2

    #region ��Ӱ�����Ӧ
    public override void OnButton1Click()
    {
        base.moodLevelMinus();
        uiManager.uiChat.ChangeChatText("�����ںܲ����ˣ���Ҫ�ټ�����");
        if (moodLevel <= -10) badMood();
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
    public override void badMood()
    {
        
        GSI.GameOver();
        //player.SetActive(false);
    }
    public override void goodMood()
    {
        giveKey = true;
    }
}
