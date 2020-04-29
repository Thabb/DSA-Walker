using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIElement : MonoBehaviour
{
    public SceneMaster sceneMaster;

    public bool hideIfNotOnTop = false;

    public void Show()
    {
        gameObject.SetActive(true);
        sceneMaster.openGUIElements.Add(this);

        // Take a look if the former top GUIElement should be hidden
        if (sceneMaster.openGUIElements.Count > 1)
        {
            GUIElement secondElement = sceneMaster.openGUIElements[sceneMaster.openGUIElements.Count - 2];
            if (secondElement.hideIfNotOnTop == true) secondElement.gameObject.SetActive(false);
        }
    }

    public void Hide()
    {
        gameObject.SetActive(false);
        sceneMaster.openGUIElements.Remove(this);

        // Make sure, that the now on top lying GUIElement is active again if it was disabled before
        if (sceneMaster.openGUIElements.Count > 0)
        {
            GUIElement topElement = sceneMaster.openGUIElements[sceneMaster.openGUIElements.Count - 1];
            topElement.gameObject.SetActive(true);
        }
    }
}
