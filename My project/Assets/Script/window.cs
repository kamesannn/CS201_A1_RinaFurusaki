using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class window : MonoBehaviour
{
    public Image closedWindow;
    public Sprite opendedWindow;
    

    public void ChangeWindowToOpen()
    {
        closedWindow.sprite = opendedWindow;
    }
}
