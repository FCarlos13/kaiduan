using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    #region ���
    UIManager uiManager;
    #endregion
    #region ����=============================
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

    #region ״̬=============================
    bool isGameOver;
    #endregion

    #region ����=============================
    //ϵͳ�������أ����أ���Ϸ����

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
        //1. ���Ŷ���
        uiManager.uiDie.ShowWithCanvasGroup();
        Debug.Log("real game over");
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

    #region �ص�=============================
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
