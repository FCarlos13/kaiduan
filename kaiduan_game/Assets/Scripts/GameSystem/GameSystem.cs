using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    #region 组件
    public UIManager uiManager;
    #endregion
    #region 数据=============================
    const int MAXCHANCES = 15;
    public static GameSystem Instance { get; set; }

    private int chancesLeftToPushE = 5;
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
        set { chancesLeftToPushE = value; }
    }

    #endregion

    #region 状态=============================
    bool isGameOver;
    public bool isGameRunning;
    #endregion

    #region 方法=============================
    //系统启动加载，重载，游戏结束

    void InitGame(int timeToPushE)
    {
        isGameOver = false;
        chancesLeftToPushE = timeToPushE;
        extraChances = 0;
        //uiManager = GameObject.Find("MainCanvas").GetComponent<UIManager>();
    }
    //void ReloadGame(int timeToPushE)
    //{
    //    this.chancesLeftToPushE = timeToPushE;
    //}

    public void GameOver()//TODO
    {
        //1. 播放动画TODO
        uiManager.uiDie.ShowWithCanvasGroup();
        isGameOver = true;
    }

    void CheckIfGameOver()
    {
        if (this.chancesLeftToPushE == 0)
        {
            GameOver();
        }
        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                extraChances += 2;
                SceneManager.LoadScene(0);
                InitGame(chancesLeftToPushE + extraChances);
            }
        }
    }

    #endregion

    #region 回调=============================
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        InitGame(chancesLeftToPushE + extraChances);
    }
    private void Start()
    {
        Debug.Log("first load scene");
        //systemControl = GameObject.Find("SystemControl");
        uiManager = GameObject.Find("MainCanvas").GetComponent<UIManager>();
    }
    private void Update()
    {
        CheckIfGameOver();
    }
    #endregion
}
