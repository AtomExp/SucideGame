using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Options;
    public GameObject Mainmenu;
    public void StartScene()
    {
        SceneManager.LoadScene("SampleScene");
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

}
