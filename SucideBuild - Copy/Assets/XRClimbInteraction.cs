using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRClimbInteraction : XRBaseInteractable
{
    protected override void OnSelectEntered(XRBaseInteractor interact)
    {
        base.OnSelectEntered(interact);

        if (interact is XRDirectInteractor)
        {
            XRPlayerClimb.climbing = interact.GetComponent<XRController>();
        }
    }

    protected override void OnSelectExited(XRBaseInteractor interact)
    {
        base.OnSelectExited(interact);

        if(interact is XRDirectInteractor)
        {
            if(XRPlayerClimb.climbing && XRPlayerClimb.climbing.name == interact.name)
            {
                XRPlayerClimb.climbing = null;
            }
        }
    }


}
