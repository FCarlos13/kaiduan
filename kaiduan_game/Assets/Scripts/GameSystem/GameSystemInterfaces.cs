using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//渐渐地做成了子系统与游戏系统的统一接口
public class GameSystemInterfaces : MonoBehaviour
{
    #region 数据
    public GameObject gameSystem;
    private GameSystem obj;
    GlobalStatusDatabase database = new GlobalStatusDatabase();
    #endregion

    #region 接口函数

    #region 只读
    public int GetChancesNum()
    {
        return obj.ChancesLeftToPushEAttribute;
    }
    public bool IsGameRunning()
    {
        return obj.isGameRunning;
    }
    #endregion

    #region 只写
    public void PlusExtraChances(int i)
    {//当触发某些条件可额外增加使用E的次数
        obj.ExtraChancesAttribute += i;
    }
    public void MinusChances()
    {
        obj.ChancesLeftToPushEAttribute -= 1;
    }
    public void AllignGSComponent(UIManager ui)
    {
        obj.uiManager = ui;
    }
    #endregion

    #region 读写

    #endregion

    #region 改变状态
    public void GameOver()
    {
        obj.GameOver();
    }
    #endregion

    #endregion

    #region 回调
    private void Awake()
    {
        obj = gameSystem.GetComponent<GameSystem>();
    }
    
    #endregion
}
