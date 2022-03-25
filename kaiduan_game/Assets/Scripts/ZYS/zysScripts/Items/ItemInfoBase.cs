using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfoBase : MonoBehaviour
{
    public Camera target;
    public void LookAtCamera()
    {
        transform.rotation = Quaternion.LookRotation(target.transform.forward);
    }
    public virtual void Show()
    {
        gameObject.SetActive(true);
    }
    public virtual void Hide()
    {
        gameObject.SetActive(false);
    }

}
