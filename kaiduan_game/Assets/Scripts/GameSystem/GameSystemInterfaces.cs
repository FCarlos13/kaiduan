using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystemInterfaces : MonoBehaviour
{
    #region 数据
    public GameObject gameSystem;
    #endregion

    #region 接口函数
    //当触发某些条件可额外增加使用E的次数
    public void PlusExtraChances(int i)
    {
        gameSystem.ExtraChancesAttribute = i;
    }

    public int GetChancesNum()
    {
        return gameSystem.ChancesLeftToPushEAttribute;
    }

    public void GameOver()
    {
        gameSystem.GameOver();
    }
    #endregion

    #region 回调
    
    #endregion
}
