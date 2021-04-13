using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppManager : MonoBehaviour
{
    public void LanguangeSelect()
    {
        SceneManager.LoadScene("MainMenuID");
    }

    public void MainMenuId()
    {
        SceneManager.LoadScene("LanguangeSelect");
    }

    public void MainMenuEng()
    {
        SceneManager.LoadScene("MainMenuEng");
    }

    public void ARsceneId()
    {
        SceneManager.LoadScene("ARsceneID");
    }

    public void ARsceneEng()
    {
        SceneManager.LoadScene("ARsceneEng");
    }

    public void QuitApps()
    {
        Application.Quit();
    }
}
