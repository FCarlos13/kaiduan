using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagItem : ItemInfoBase
{
    public ThirdPersonController player;
    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;

    public void check_Item1()
    {
        if (player.isGetItem1) Item1.SetActive(true);
        else Item1.SetActive(false);
    }
    public void check_Item2()
    {
        if (player.isGetItem2) Item2.SetActive(true);
        else Item2.SetActive(false);
    }
    public void check_Item3()
    {
        if (player.isGetItem3) Item3.SetActive(true);
        else Item3.SetActive(false);
    }
}
