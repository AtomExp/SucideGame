using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionManager : MonoBehaviour
{
    public TeleportationProvider teleportProvider;
    public ContinuousMoveProviderBase continuousMoveProvider;

    void Start()
    {
        teleportProvider = GetComponent<TeleportationProvider>();
        continuousMoveProvider = GetComponent<ContinuousMoveProviderBase>();
    }

    private void OnEnable()
    {
        EnableFall.fallTriggered += EnableContinuous;
        EnableFall.fallTriggered += DisableTeleport;
    }

    private void OnDisable()
    {
        EnableFall.fallTriggered -= EnableContinuous;
        EnableFall.fallTriggered -= DisableTeleport;
    }

    public void EnableContinuous()
    {
        continuousMoveProvider = this.gameObject.GetComponent<ContinuousMoveProviderBase>();
        continuousMoveProvider.enabled = true;
    }

    public void DisableTeleport()
    {
        teleportProvider = this.gameObject.GetComponent<TeleportationProvider>();
        teleportProvider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
