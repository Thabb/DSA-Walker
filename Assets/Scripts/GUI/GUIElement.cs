using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIElement : MonoBehaviour
{
    public SceneMaster sceneMaster; 

    public void Show()
    {
        gameObject.SetActive(true);
        sceneMaster.openGUIElements.Add(this);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
        sceneMaster.openGUIElements.Remove(this);
    }
}
