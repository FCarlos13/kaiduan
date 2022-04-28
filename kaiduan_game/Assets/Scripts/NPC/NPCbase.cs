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
    public GameObject MainCamera;
    #endregion

    #region 状态
    public bool canCommunicate;
    public bool giveKey;
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

    public virtual void OnButton1Click() { }
    public virtual void OnButton2Click() { }
    public virtual void OnButton3Click() { }

    #endregion

    #region 回调
    void OnTriggerEnter(Collider other)
    {
        uiManager.uiChat.bt1.onClick.AddListener(OnButton1Click);
        uiManager.uiChat.bt2.onClick.AddListener(OnButton2Click);
        uiManager.uiChat.bt3.onClick.AddListener(OnButton3Click);
        //TODO显示按E
    }
    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(uiManager.uiChat.bt1);
        if (Input.GetKeyDown(KeyCode.E))
        {
            checkPlayerWantToCommunicate();
            GSI.MinusChances();
            if (GameObject.Find("CM FreeLook1"))
            {
                MainCamera.SetActive(false);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        uiManager.uiChat.HideWithCanvasGroup();
        if (!GameObject.Find("CM FreeLook1"))
        {
            MainCamera.SetActive(true);
        }
        uiManager.uiChat.bt1.onClick.RemoveAllListeners();
        uiManager.uiChat.bt2.onClick.RemoveAllListeners();
        uiManager.uiChat.bt3.onClick.RemoveAllListeners();
        uiManager.uiChat.ResumeAllButton();
    }
    private void Start()
    {
        player = GameObject.Find("Fox").GetComponent<PlayerController>();
        uiManager = GameObject.Find("MainCanvas").GetComponent<UIManager>();
        GSI = GameObject.Find("SystemControl").GetComponent<GameSystemInterfaces>();
        MainCamera = GameObject.Find("CM FreeLook1");

        canCommunicate = true;
        giveKey = false;
    }
    #endregion
}
