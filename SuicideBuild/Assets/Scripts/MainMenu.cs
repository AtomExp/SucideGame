using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Options;
    public GameObject Mainmenu;
    public GameObject skinMenu;
    public SelectColor colorscript;

    public void StartScene()
    {
        if (!colorscript.picked)
        {
            colorscript.playerMat.color = colorscript.skinMats[1].color;
        }
        SceneManager.LoadScene("Apartment Scene");
    }

    public void openOptions()
    {
        Options.SetActive(true);
        Mainmenu.SetActive(false);
    }
    public void closeOptions()
    {
        Options.SetActive(false);
        Mainmenu.SetActive(true);
    }

    public void openSkinMenu()
    {
        skinMenu.SetActive(true);
        Options.SetActive(false);
    }

    public void closeSkinMenu()
    {
        skinMenu.SetActive(false);
        Options.SetActive(true);
    }

}
