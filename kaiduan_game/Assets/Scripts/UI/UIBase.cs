using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBase : MonoBehaviour
{
    public virtual void HideWithCanvasGroup()
    {
        GetComponent<CanvasGroup>().alpha = 0;
        GetComponent<CanvasGroup>().interactable = false;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    public virtual void ShowWithCanvasGroup()
    {
        GetComponent<CanvasGroup>().alpha = 1;
        GetComponent<CanvasGroup>().interactable = true;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
