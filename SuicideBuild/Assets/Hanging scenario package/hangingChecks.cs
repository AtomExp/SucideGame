using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hangingChecks : MonoBehaviour
{
    public bool hasRope = false;
    public bool onChair = false;
    public bool decisionTime = false;
    public bool nooseIsUp = false;
    public bool hasPlant = false;

    public GameObject noose, player, chair, hangingPlant;

    public void pickedUpRope()
    {
        hasRope = true;
    }

    public void updateDecision()
    {
        if(nooseIsUp)
        {
            decisionTime = true;
        }
    }

    public void movePlayerOnChair()
    {
        if (hasRope)
        {
            onChair = true;
            player.transform.position = chair.transform.position + new Vector3(0, 1f, 0);
        }
    }

    public void placeNoose()
    {
        if (hasRope && onChair)
        {
            noose.SetActive(true);
            nooseIsUp = true;
        }
    }

    public void getDown()
    {
        if (decisionTime)
        {
            player.transform.position = new Vector3(-8.5f, 71.2f, -15.21f);
        }
    }

    public void getInNoose()
    {
        if (decisionTime)
        {
            player.transform.position = new Vector3(-9.1f, 71.922f, -16.156f);
        }
    }

    public void pickedUpPlant()
    {
        hasPlant = true;
    }

    public void placePlant()
    {
        if (hasPlant)
        {
            hangingPlant.SetActive(true);
        }
    }
}