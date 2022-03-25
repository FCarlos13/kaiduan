using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1 : NPCbase
{//小女孩，特殊之处在于心情坏了之后就不想与你交流,高兴了就会给你道具1
    private void OnTriggerEnter(Collider other)
    {
        uiManager.uiChat.bt1.onClick.AddListener(OnButton1Click);
        uiManager.uiChat.bt2.onClick.AddListener(OnButton2Click);
        uiManager.uiChat.bt3.onClick.AddListener(OnButton3Click);
        //TODO显示按E
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

    #region 添加按键响应
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
        uiManager.uiChat.ChangeChatText("好了好了");
    }
    #endregion

    #region 函数
    public override void badMood()
    {
        //Debug.Log("对方现在很生气");
        canCommunicate = false;
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
