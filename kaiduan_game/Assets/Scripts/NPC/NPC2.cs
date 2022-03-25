using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC2 : NPCbase
{//普通人，心情坏了也能交流，特殊之处在于一但心情值低于-20，就会导致player被他杀害，心情值高兴的时候,并且还要你获得了道具1才会给你道具2

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
        //gameover();//同时弹出提示UI表明你被他杀了
        //player.SetActive(false);
    }
    public override void goodMood()
    {
        giveKey = true;
    }
}
