using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionItem : MonoBehaviour
{
    //public GameObject refuseUI;
    //public GameObject MissionCompleteUI;
    #region ���
    public PlayerController player;
    UIManager uiManager;
    #endregion
    public bool missionComplete = false;
    private void OnTriggerStay(Collider other)
    {
        
        if (player.CommunicateTrigger==true)
        {
            //Debug.Log("���������");
            if (missionComplete==true)
            {
                //refuseUI.SetActive(false);
                //MissionCompleteUI.SetActive(true);
                //uiManager.uiDie.
            }
            //else { refuseUI.SetActive(true); }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //MissionCompleteUI.SetActive(false);
        //refuseUI.SetActive(false);
    }

    private void Start()
    {
        uiManager = GameObject.Find("MainCanvas").GetComponent<UIManager>();
    }
}
