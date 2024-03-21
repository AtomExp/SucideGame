using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStartStop : MonoBehaviour
{
    private Animator mAnimator;
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        mAnimator.SetTrigger("TrStart");
    }

    // Update is called once per frame
    void Update()
    {
        if (mAnimator != null)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {

                mAnimator.SetTrigger("TrStart");
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                mAnimator.SetTrigger("TrStop");
            }
        }
    }
}
