using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystemInterfaces : MonoBehaviour
{
    #region 数据
    public GameObject gameSystem;
    private GameSystem obj;
    #endregion

    #region 接口函数
    //当触发某些条件可额外增加使用E的次数
    public void PlusExtraChances(int i)
    {
        obj.ExtraChancesAttribute += i;
    }

    public int GetChancesNum()
    {
        return obj.ChancesLeftToPushEAttribute;
    }

    public void GameOver()
    {
        Debug.Log("interfaces gameover");
        obj.GameOver();
    }
    #endregion

    #region 回调
    private void Awake()
    {
        //if (GameSystem.Instance == null)
        //{
        //    GameObject.Instantiate(gameSystem);
        //}
        obj = gameSystem.GetComponent<GameSystem>();
    }
    
    #endregion
}
