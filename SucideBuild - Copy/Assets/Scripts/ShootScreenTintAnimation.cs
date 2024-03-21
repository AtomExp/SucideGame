using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ShootScreenTintAnimation : MonoBehaviour
{
    //Attach to Tint image on a Canvas
    //Canvas is attached to VR Main Camera where Z position = .05
    

    public Animation screenTint; //Animation is DeathScreenAnimation, unnecessary due to Tint animator component

    public Volume v;
    public Camera VRCamera;
    public Transform target;
    public Animator dAnimation; //Animator is titled "Tint"
    //public GameObject jumpBox;

    void Start()
    {
        screenTint = gameObject.GetComponent<Animation>();
        target = VRCamera.transform;
        dAnimation = GetComponent<Animator>();
        v = GetComponent<Volume>();
       // jumpBox = GameObject.FindWithTag("jumpBox");
        //d = v.GetComponent<DepthOfField>();
    }

    // Update is called once per frame
    void Update()
    {
        //Position in front of the camera
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 0, 0.1f));
        //d.focalLength = new ClampedFloatParameter(10, 10, 62, true);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            dAnimation.SetTrigger("Tint");
        }

    }
    private void OnTriggerEnter(Collider jumpBox)
    {
        dAnimation.SetTrigger("Tint");
    }
}
