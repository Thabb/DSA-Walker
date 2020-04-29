using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMaster : MonoBehaviour
{
    public GUIElement pauseMenu;

    public List<GUIElement> openGUIElements { get; set; }  = new List<GUIElement>();
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (openGUIElements.Count != 0)
            {
                openGUIElements[openGUIElements.Count - 1].Hide();
            } else
            {
                pauseMenu.Show();
            }
        }
    }
}
