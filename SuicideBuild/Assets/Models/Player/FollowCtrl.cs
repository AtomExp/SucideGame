using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCtrl : MonoBehaviour
{

    [SerializeField] GameObject followObj;
    [SerializeField] bool followPos, followRot;
    [SerializeField] Quaternion adjustRot;
    private void Update()
    {
        if (followPos)
        {
            this.transform.position = followObj.transform.position;
        }
        if (followRot)
        {
            this.transform.rotation = followObj.transform.rotation * adjustRot;
        }
    }
}
