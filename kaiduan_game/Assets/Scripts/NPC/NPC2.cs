using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC2 : NPCbase
{//��ͨ�ˣ����黵��Ҳ�ܽ���������֮������һ������ֵ����-20���ͻᵼ��player����ɱ��������ֵ���˵�ʱ��,���һ�Ҫ�����˵���1�Ż�������2

    private void OnTriggerStay(Collider other)
    {
        checkPlayerWantToCommunicate();
    }
    private void OnTriggerExit(Collider other)
    {
        uiManager.uiChat.HideWithCanvasGroup();
    }
    public override void badMood()
    {
        
        GSI.GameOver();
        //gameover();//ͬʱ������ʾUI�����㱻��ɱ��
        //player.SetActive(false);
    }
    public override void goodMood()
    {
        giveKey = true;
    }
}