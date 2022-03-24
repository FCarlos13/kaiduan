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

    //������
    ////��һ�����д����Ϣ���е���ʽ======================================TODO
    //#region �ṩ�ⲿ�˽�ϵͳ��״̬�Ƿ�仯���Ӷ����ⷴ������ϵͳ����
    //public bool isChancesChanged = false;
    //#endregion
    //#region �����ⲿ���ص��Ѿ�ʹ���˵�ǰ��״̬�仯����Ҫ���ȥ
    //public void AcceptInfo(int i)
    //{
    //    int k = i;
    //    switch (k)
    //    {
    //        case 1: 
    //            isChancesChanged = !isChancesChanged;
    //            break;
    //        //�����Ŀ������
    //    }
    //}
    //#endregion
    ////==================================================================



    #region �ӿں���
    //==================================
    #region ֻ��
    public int GetChancesNum()
    {
        return obj.ChancesLeftToPushEAttribute;
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
    #endregion

    #region ��д
    #endregion

    #region �ı�״̬
    public void GameOver()
    {
        //Debug.Log("interfaces gameover");
        obj.GameOver();
    }
    #endregion
    //==================================
    #endregion

    #region �ص�
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
