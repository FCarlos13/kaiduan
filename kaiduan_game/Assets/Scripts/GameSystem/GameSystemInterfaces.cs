using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystemInterfaces : MonoBehaviour
{
    #region ����
    public GameObject gameSystem;
    #endregion

    #region �ӿں���
    //������ĳЩ�����ɶ�������ʹ��E�Ĵ���
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

    #region �ص�
    
    #endregion
}
