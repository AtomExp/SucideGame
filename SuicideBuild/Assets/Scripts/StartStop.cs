using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStop : MonoBehaviour
{
    private Animator mAnimator;
    [SerializeField] private GameObject animationObject;
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(mAnimator != null)
        {
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
               
               mAnimator.SetTrigger("TrStart");
            }

            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                mAnimator.SetTrigger("TrStop");
            }
        }
    }
}
