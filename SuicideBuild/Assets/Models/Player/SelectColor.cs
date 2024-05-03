using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectColor : MonoBehaviour
{
    [SerializeField] List<Material> skinMats;
    [SerializeField] Material playerMat;

    public void ChangeSkinColor(int colorIndex)
    {
        playerMat.color = skinMats[colorIndex].color;
    }
}
