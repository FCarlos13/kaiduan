using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionItem : MonoBehaviour
{
    public GameObject refuseUI;
    public GameObject MissionCompleteUI;
    public bool missionComplete = false;
    public ThirdPersonController player;
    private void OnTriggerStay(Collider other)
    {
        
        if (player.CommunicateTrigger==true)
        {
            //Debug.Log("Ω¯»ÎºÏ≤‚”Ôæ‰");
            if (missionComplete==true)
            {
                refuseUI.SetActive(false);
                MissionCompleteUI.SetActive(true);
            }
            else { refuseUI.SetActive(true); }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        MissionCompleteUI.SetActive(false);
        refuseUI.SetActive(false);
    }
}
