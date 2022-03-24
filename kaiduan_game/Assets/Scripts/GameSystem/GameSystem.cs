using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    #region ����=============================
    const int MAXCHANCES = 10;

    //��������������Ϸʱ�����ݻٵĶ���
    //�����ݻٵĶ��󶼹���һ���������ϡ�
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

    #region ״̬=============================
    bool isGameOver;
    #endregion

    #region ����=============================
    //ϵͳ�������أ����أ���Ϸ����

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

        //1. ���Ŷ���
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

    #region �ص�=============================

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
