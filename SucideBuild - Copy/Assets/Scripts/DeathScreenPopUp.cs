using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreenPopUp : MonoBehaviour
{
    private Animator mAnimator;

	private void OnEnable()
	{
        DeathScreenTriggerScript.deathTriggered += TriggerDeath;
	}
    private void OnDisable()
    {
        DeathScreenTriggerScript.deathTriggered -= TriggerDeath;
    }
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        mAnimator.SetTrigger("TrMenuDown");
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
    }
    public void TriggerDeath()
    {
        mAnimator.SetTrigger("TrMenuUp");
    }
}
