using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCid : UIBase
{
    public Camera mainCamera;

    void Update()
    {
        transform.rotation = Quaternion.LookRotation(mainCamera.transform.forward);
    }
}
