using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Chances : UIBase
{
    Text obj;//Ψһһ����Ҫ�䶯��ֵ

    public void ChangeNum(int i)
    {
        //if (int.Parse(obj.text) != i)
        //{
        //    obj.text = i.ToString();
        //}
        obj.text = i.ToString();
    }
    private void Awake()
    {
        obj = transform.Find("ChancesLeftNum").gameObject.GetComponent<Text>();
    }
}
