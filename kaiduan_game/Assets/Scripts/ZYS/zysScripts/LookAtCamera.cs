using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public Camera target;

    void Update()
    {
        transform.rotation = Quaternion.LookRotation(target.transform.forward);
    }
}
