using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    public void ResumeButton()
    {
        pauseMenu.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
