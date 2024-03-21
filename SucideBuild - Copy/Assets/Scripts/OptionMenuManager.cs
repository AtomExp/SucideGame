using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OptionMenuManager : MonoBehaviour
{
    public GameObject optionsMenu;
    public InputActionProperty showButton;
    public Transform head;
    public float spawnDistance = 2;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(showButton.action.WasPressedThisFrame())
        {
            Debug.Log("Pressed!");

            optionsMenu.SetActive(!optionsMenu.activeSelf);

            optionsMenu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        }

        optionsMenu.transform.LookAt(new Vector3(head.position.x, optionsMenu.transform.position.y, head.position.z));
        optionsMenu.transform.forward *= -1;
    }
}
