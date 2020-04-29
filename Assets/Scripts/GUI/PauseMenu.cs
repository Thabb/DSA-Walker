using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : GUIElement
{
    public void ResumeButton()
    {
        Hide();
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
