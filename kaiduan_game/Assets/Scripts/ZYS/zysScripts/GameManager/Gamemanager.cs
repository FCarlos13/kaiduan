using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{//本脚本作用仅仅为监视各个controller里面的数值和状态，并且根据其中一个组件的数值和状态，变化其他组件的数值状态，具体实现细节放在组件各自的controller里面
    public ItemController ItemController;
    public NPCcontroller npcController;
    public GameSystem gameSystem;
    public ThirdPersonController player;
    private void Update()
    {
        if(npcController.npc1.giveKey == true)player.isGetItem1 = true;
        if(npcController.npc2.giveKey == true && npcController.npc1.giveKey == true) player.isGetItem2 = true;
        if (npcController.npc3.giveKey == true) player.isGetItem3 = true;
        if (player.isGetItem1 == true && player.isGetItem2 == true && player.isGetItem3 == true) 
            ItemController.missionItem.missionComplete = true;
    }
}
