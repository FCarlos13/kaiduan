using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCcontroller : MonoBehaviour
{//本脚本主要负责接受各个NPC的数据，从而来决定获得Item的条件是否达成
    #region 组件
    public NPC1 npc1;
    public NPC2 npc2;
    public NPC3 npc3;
    #endregion

    #region 函数
    
    public void NPC2Controller()
    {
        if (npc2.moodLevel <= -20) { npc2.badMood(); }
        else if (npc2.moodLevel >= 20) npc2.goodMood();
    }
    public void NPC3Controller()
    {
        if (npc3.moodLevel <= 0) npc3.badMood();
        else if (npc3.moodLevel >= 20 && npc1.moodLevel >= 20) npc3.goodMood();
    }
    #endregion

    
}
