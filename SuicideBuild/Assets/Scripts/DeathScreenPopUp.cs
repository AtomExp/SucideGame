using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreenPopUp : MonoBehaviour
{
    private Animator mAnimator;
    private bool isDying = false;

    public GameObject isAliveScreen;
    public GameObject DeathScreen;

    public Animator Darkscreen;

	private void OnEnable()
	{
        DeathScreenTriggerScript.deathTriggered += TriggerDeath;
        DeathScreenTriggerScript.deathTriggeredLonger += TriggerDeathLonger;
    }
    private void OnDisable()
    {
        DeathScreenTriggerScript.deathTriggered -= TriggerDeath;
        DeathScreenTriggerScript.deathTriggeredLonger -= TriggerDeathLonger;
    }
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        mAnimator.SetTrigger("TrMenuDown");
        DeathScreen.SetActive(true);
        isAliveScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (mAnimator != null)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                mAnimator.SetTrigger("TrMenuUp");
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                mAnimator.SetTrigger("TrMenuDown");
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PauseDeath();
        }
    }
    public void TriggerDeath()
    {
        mAnimator.SetTrigger("TrMenuUp");
        isDying = true;
    }
    public void TriggerDeathLonger()
    {
        mAnimator.SetTrigger("LongerDeath");
        isDying = true;
    }

    public void PauseDeath()
    {
        if (isDying)
        {
            DeathScreen.SetActive(false);
            isAliveScreen.SetActive(true);
            Darkscreen.speed = 0;
        }
    }
}
