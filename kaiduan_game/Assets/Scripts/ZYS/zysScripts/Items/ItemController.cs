using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public BagItem bagItem;
    public MissionItem missionItem;
    private void Update()
    {
        checkBagItemStatus();
    }
    public void checkBagItemStatus()
    {
        bagItem.check_Item1();
        bagItem.check_Item2();
        bagItem.check_Item3();
    }
}
