using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{//���ű����ý���Ϊ���Ӹ���controller�������ֵ��״̬�����Ҹ�������һ���������ֵ��״̬���仯�����������ֵ״̬������ʵ��ϸ�ڷ���������Ե�controller����
    public ItemController ItemController;
    public NPCcontroller npcController;
    //public GameSystem gameSystem;
    public PlayerController player;
    private void Update()
    {
        if(npcController.npc1.giveKey == true)player.isGetItem1 = true;
        if(npcController.npc2.giveKey == true && npcController.npc1.giveKey == true) player.isGetItem2 = true;
        if (npcController.npc3.giveKey == true) player.isGetItem3 = true;

        if (player.isGetItem1 && player.isGetItem2 && player.isGetItem3 && !ItemController.missionItem.missionComplete) 
            ItemController.missionItem.missionComplete = true;
    }
}
