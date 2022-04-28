using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC3 : NPCbase
{//父亲，心情值生气时也愿意和你交流，特殊之处在于必须要NPC1处于高兴状态，同时自身心情值也要高兴才会给你道具3
    #region 添加按键响应
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

    #region 函数
    public override void badMood()
    {
        //Debug.Log(GameObject.Find("MainCanvas"));
        canCommunicate = false;
        uiManager.uiChat.ChangeChatText("你好烦啊，不想跟你说话了");
        uiManager.uiChat.HideAllButtons();
    }
    public override void goodMood()
    {
        //Debug.Log("对方现在很开心");
        giveKey = true;
        //canCommunicate = true;
        //player.isGetItem1 = true;
    }
    #endregion
}
