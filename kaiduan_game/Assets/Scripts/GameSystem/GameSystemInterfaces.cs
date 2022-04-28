using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��������������ϵͳ����Ϸϵͳ��ͳһ�ӿ�
public class GameSystemInterfaces : MonoBehaviour
{
    #region ����
    public GameObject gameSystem;
    private GameSystem obj;
    GlobalStatusDatabase database = new GlobalStatusDatabase();
    #endregion

    #region �ӿں���

    #region ֻ��
    public int GetChancesNum()
    {
        return obj.ChancesLeftToPushEAttribute;
    }
    public bool IsGameRunning()
    {
        return obj.isGameRunning;
    }
    #endregion

    #region ֻд
    public void PlusExtraChances(int i)
    {//������ĳЩ�����ɶ�������ʹ��E�Ĵ���
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

    #region ��д

    #endregion

    #region �ı�״̬
    public void GameOver()
    {
        obj.GameOver();
    }
    #endregion

    #endregion

    #region �ص�
    private void Awake()
    {
        obj = gameSystem.GetComponent<GameSystem>();
    }
    
    #endregion
}
