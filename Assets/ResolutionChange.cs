using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionChange : MonoBehaviour
{
    public GameObject panel;

    public void TogglePanel()
    {
        panel.SetActive(!panel.activeSelf);
    }

    public void OnClick_1600x900()
    {
        Screen.SetResolution(1600, 900, Screen.fullScreen);
    }

    public void OnClick_1280x720()
    {
        Screen.SetResolution(1280, 720, Screen.fullScreen);
    }

    public void OnClick_1920x1080()
    {
        Screen.SetResolution(1920, 1080, Screen.fullScreen);
    }
}