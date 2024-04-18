using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EnableFall : MonoBehaviour
{
    public delegate void OnFallTrigger();
    public static OnFallTrigger fallTriggered;
    public bool isFalling = false;
    public GameObject fallPrompt;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "enablefall")
        {
            fallPrompt.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "enablefall")
        {
            fallPrompt.SetActive(false);
        }
    }

    public void Fall()
    {
        this.gameObject.transform.position = new Vector3(7.69f, 71.2f, -12.5f);
        Debug.Log("I'm falling");
    }
}
