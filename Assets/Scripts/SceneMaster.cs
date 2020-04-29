using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMaster : MonoBehaviour
{
    public GUIElement pauseMenu;

    private List<GUIElement> _openGUIElements = new List<GUIElement>();
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (_openGUIElements.Count != 0)
            {
                _openGUIElements[_openGUIElements.Count - 1].Hide();
                _openGUIElements.RemoveAt(_openGUIElements.Count - 1);
            } else
            {
                pauseMenu.Show();
                _openGUIElements.Add(pauseMenu);
            }
        }
    }
}
