using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMe : MonoBehaviour
{
    private void OnEnable()
    {
        EnableFall.fallTriggered += DisableCollider;
    }

    private void OnDisable()
    {
        EnableFall.fallTriggered -= DisableCollider;
    }
    void DisableCollider()
	{
        GetComponent<MeshCollider>().convex = true;
        GetComponent<MeshCollider>().isTrigger = true;
    }
}
