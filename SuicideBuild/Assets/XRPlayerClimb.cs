using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class XRPlayerClimb : MonoBehaviour
{
    private CharacterController player;
    public static XRController climbing;
    private CharMovementAddon cMA;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
        cMA = GetComponent<CharMovementAddon>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(climbing)
        {
            cMA.enabled = false;
            PlayerClimb();
        }
        else
        {
            cMA.enabled = true;
        }
    }

    void PlayerClimb()
    {
        InputDevices.GetDeviceAtXRNode(climbing.controllerNode).TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 velocity);

        player.Move(transform.rotation * -velocity * Time.fixedDeltaTime);
    }
}
