using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectColor : MonoBehaviour
{
    [SerializeField] List<Material> skinMats;
    [SerializeField] List<GameObject> playerMats;
    [SerializeField] SkinColor skinColor;

    public void OnClick()
    {
        Debug.Log("Start");
        switch (skinColor)
        {
            case SkinColor.One:
                ChangeSkinColor(skinMats[0]); break;
            case SkinColor.Two:
                ChangeSkinColor(skinMats[1]); break;
            case SkinColor.Three:
                ChangeSkinColor(skinMats[2]); break;
            case SkinColor.Four:
                ChangeSkinColor(skinMats[3]); break;
            case SkinColor.Five:
                ChangeSkinColor(skinMats[4]); break;
        }
        Debug.Log("End");
    }

    void ChangeSkinColor(Material color)
    {
        foreach (GameObject obj in playerMats)
        {
            obj.GetComponent<MeshRenderer>().material = color;
        }
    }

    enum SkinColor
    {
        One, Two, Three, Four, Five
    }
}
