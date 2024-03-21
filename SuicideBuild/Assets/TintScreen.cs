using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TintScreen : MonoBehaviour
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
    }
    public void TriggerDeath()
    {
        mAnimator.SetTrigger("TrStart");
    }
}
