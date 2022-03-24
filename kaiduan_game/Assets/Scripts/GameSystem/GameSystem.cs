using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    #region 数据=============================
    const int MAXCHANCES = 10;

    //用来保存重置游戏时不被摧毁的对象，
    //不被摧毁的对象都挂在一个空物体上。
    public GameObject systemControl;

    private int chancesLeftToPushE;
    private int extraChances;

    public int ExtraChancesAttribute
    {
        get { return extraChances; }
        set {
            if (chancesLeftToPushE + extraChances > MAXCHANCES)
            { extraChances = MAXCHANCES - chancesLeftToPushE; }
            //else if(chancesLeftToPushE + extraChances < 0)
            //{ }
            else
            { extraChances = value; } 
        }
    }
    public int ChancesLeftToPushEAttribute
    {
        get { return chancesLeftToPushE; }
    }

    #endregion

    #region 状态=============================
    bool isGameOver;
    #endregion

    #region 方法=============================
    //系统启动加载，重载，游戏结束

    void InitGame()
    {
        isGameOver = false;
        chancesLeftToPushE = 5;
        extraChances = 0;
        GameObject.DontDestroyOnLoad(systemControl);
    }
    void ReloadGame(int timeToPushE)
    {
        this.chancesLeftToPushE = timeToPushE;
    }

    public void GameOver()//TODO
    {

        //1. 播放动画
        //startOver = true;
        isGameOver = true;
    }

    void CheckIfGameOver()
    {
        if (this.chancesLeftToPushE == 1)
        {
            GameOver();
        }
        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                ReloadGame(chancesLeftToPushE + extraChances);
                SceneManager.LoadScene(0);
            }
        }
    }

    #endregion

    #region 回调=============================

    private void Start()
    {
        Debug.Log("first load scene");
        systemControl = GameObject.Find("SystemControl");
        InitGame();
    }
    private void Update()
    {
        CheckIfGameOver();
    }
    #endregion
}
