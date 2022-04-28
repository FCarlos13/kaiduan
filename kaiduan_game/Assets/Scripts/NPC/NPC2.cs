using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC2 : NPCbase
{//普通人，心情坏了也能交流，特殊之处在于一但心情值低于-20，就会导致player被他杀害，心情值高兴的时候,并且还要你获得了道具1才会给你道具2

    #region 添加按键响应
    public override void OnButton1Click()
    {
        base.moodLevelMinus();
        uiManager.uiChat.ChangeChatText("我现在很不高兴，不要再继续了");
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
