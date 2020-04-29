using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMaster : MonoBehaviour
{
    public GameObject pauseMenu;

    private List<GUIElement> _openGUIElements = new List<GUIElement>();
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (_openGUIElements.Count != 0)
            {
                _openGUIElements[_openGUIElements.Count - 1].gameObject.SetActive(false);
                _openGUIElements.RemoveAt(_openGUIElements.Count - 1);
            } else
            {
                pauseMenu.SetActive(true);
                _openGUIElements.Add(pauseMenu.GetComponent<GUIElement>());
            }
        }
    }
}
