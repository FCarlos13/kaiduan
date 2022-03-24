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

    //不好用
    ////这一块最好写成消息队列的形式======================================TODO
    //#region 提供外部了解系统的状态是否变化，从而避免反复调用系统函数
    //public bool isChancesChanged = false;
    //#endregion
    //#region 接受外部返回的已经使用了当前的状态变化，需要变回去
    //public void AcceptInfo(int i)
    //{
    //    int k = i;
    //    switch (k)
    //    {
    //        case 1: 
    //            isChancesChanged = !isChancesChanged;
    //            break;
    //        //其他的可在添加
    //    }
    //}
    //#endregion
    ////==================================================================



    #region 接口函数
    //==================================
    #region 只读
    public int GetChancesNum()
    {
        return obj.ChancesLeftToPushEAttribute;
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
    #endregion

    #region 读写
    #endregion

    #region 改变状态
    public void GameOver()
    {
        //Debug.Log("interfaces gameover");
        obj.GameOver();
    }
    #endregion
    //==================================
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
