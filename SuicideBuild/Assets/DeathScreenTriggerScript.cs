using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreenTriggerScript : MonoBehaviour
{

    public delegate void OnDeathTrigger();
    public static OnDeathTrigger deathTriggered;

    public delegate void OnDeathTriggerLonger();
    public static OnDeathTrigger deathTriggeredLonger;

    public AudioSource heartBeat;

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.tag);
        if (collider.tag == "deathtrigger")
        {
            Debug.Log("IM HIT!");
            deathTriggered();
        }
        if (collider.tag == "deathtriggerLonger")
        {
            Debug.Log("IM HIT!");
            deathTriggeredLonger();
            PlayHeartBeat();
        }
    }

    public void PlayHeartBeat()
    {
        heartBeat.Play();
    }
}
