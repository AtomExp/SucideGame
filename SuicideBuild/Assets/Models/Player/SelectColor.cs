using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectColor : MonoBehaviour
{
    [SerializeField] public List<Material> skinMats;
    [SerializeField] public Material playerMat;

    public bool picked = false;

    public void ChangeSkinColor(int colorIndex)
    {
        picked = true;
        playerMat.color = skinMats[colorIndex].color;
    }
}
