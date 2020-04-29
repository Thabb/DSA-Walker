using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : GUIElement
{
    public void ResumeButton()
    {
        gameObject.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
