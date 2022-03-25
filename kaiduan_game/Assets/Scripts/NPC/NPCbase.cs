using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCbase : MonoBehaviour
{//��ɫ��Ҫ���Ʊ������������ֵ�Լ��Ի���ĳ������أ��Ի��Ľ�������ֹ�ȣ�ȫ�ֵ��ߵ��趨����controller
    #region ����
    public int moodLevel = 10;
    #endregion

    #region ���
    //public GameObject self;
    public PlayerController player;
    public UIManager uiManager;
    public GameSystemInterfaces GSI;
    #endregion

    #region ״̬
    public bool canCommunicate = true;
    public bool giveKey = false;
    //public bool isAlive = true;
    #endregion

    #region ����
    public void checkPlayerWantToCommunicate()
    {
        if(player.CommunicateTrigger == true && canCommunicate == true )
        {
            uiManager.uiChat.ShowWithCanvasGroup();
            uiManager.uiChat.ChangeChatText("��ð�");
        }
        if(!canCommunicate)
        {
            uiManager.uiChat.ShowWithCanvasGroup();
            uiManager.uiChat.ChangeChatText("�������˵��");
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

    #region �ص�
    private void Start()
    {
        player = GameObject.Find("Fox").GetComponent<PlayerController>();
        uiManager = GameObject.Find("MainCanvas").GetComponent<UIManager>();
        GSI = GameObject.Find("SystemControl").GetComponent<GameSystemInterfaces>();
    }
    #endregion
}
