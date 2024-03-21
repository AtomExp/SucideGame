using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EnableFall : MonoBehaviour
{
    public delegate void OnFallTrigger();
    public static OnFallTrigger fallTriggered;
    public bool isFalling = false;

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.tag);
        if (collider.tag == "enablefall")
        {
            isFalling = true;
            fallTriggered();
        }
    }
}
