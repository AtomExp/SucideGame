using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreenTriggerScript : MonoBehaviour
{

    public delegate void OnDeathTrigger();
    public static OnDeathTrigger deathTriggered;

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.tag);
        if (collider.tag == "deathtrigger")
        {
            Debug.Log("IM HIT!");
            deathTriggered();
        }
    }
}
