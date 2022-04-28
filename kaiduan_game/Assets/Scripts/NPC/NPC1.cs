using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1 : NPCbase
{//小女孩，特殊之处在于心情坏了之后就不想与你交流,高兴了就会给你道具1
     

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
