using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC3 : NPCbase
{//父亲，心情值生气时也愿意和你交流，特殊之处在于必须要NPC1处于高兴状态，同时自身心情值也要高兴才会给你道具3
    private void OnTriggerStay(Collider other)
    {
        checkPlayerWantToCommunicate();
    }
    private void OnTriggerExit(Collider other)
    {
        uiManager.uiChat.HideWithCanvasGroup();
    }
    public override void goodMood()
    {
        giveKey = true;
    }
}
