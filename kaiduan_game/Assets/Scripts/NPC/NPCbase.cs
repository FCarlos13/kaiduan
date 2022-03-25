using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCbase : MonoBehaviour
{//角色主要控制本身各个变量的值以及对话框的出现隐藏，对话的进行与终止等，全局道具的设定交给controller
    #region 数据
    public int moodLevel = 10;
    #endregion

    #region 组件
    //public GameObject self;
    public PlayerController player;
    public UIManager uiManager;
    public GameSystemInterfaces GSI;
    #endregion

    #region 状态
    public bool canCommunicate = true;
    public bool giveKey = false;
    //public bool isAlive = true;
    #endregion

    #region 函数
    public void checkPlayerWantToCommunicate()
    {
        if(player.CommunicateTrigger == true && canCommunicate == true )
        {
            uiManager.uiChat.ShowWithCanvasGroup();
            uiManager.uiChat.ChangeChatText("你好啊");
        }
        if(!canCommunicate)
        {
            uiManager.uiChat.ShowWithCanvasGroup();
            uiManager.uiChat.ChangeChatText("不想跟你说话");
            uiManager.uiChat.HideAllButtons();
        }
    }
    //public virtual void Die()
    //{
    //    self.SetActive(false);
    //}
    public void moodLevelChange(int num)
    {
        moodLevel += num;
        Debug.Log(moodLevel);
    }
    public void moodLevelPlus()
    {
        this.moodLevel += 5;
        Debug.Log(moodLevel);
    }
    public void moodLevelStay()
    {
        this.moodLevel += 0;
        Debug.Log(moodLevel);
    }
    public void moodLevelMinus()
    {
        this.moodLevel += -5;
        Debug.Log(moodLevel);
    }
    public virtual void goodMood() { }
    public virtual void normalMood() { }
    public virtual void badMood() { }
    #endregion

    #region 回调
    private void Start()
    {
        player = GameObject.Find("Fox").GetComponent<PlayerController>();
        uiManager = GameObject.Find("MainCanvas").GetComponent<UIManager>();
        GSI = GameObject.Find("SystemControl").GetComponent<GameSystemInterfaces>();
    }
    #endregion
}
