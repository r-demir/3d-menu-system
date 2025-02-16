using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Toggle fullscreen, vsync;
    public ResolutionItem[] resolutions;
    public int selectedResolution;
    public Text resolutionText; 


    // Start is called before the first frame update
    void Start()
    {
        Screen.fullScreen = true;
        selectedResolution = 0;
        UpdateResolution();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApplyGraphics() 
    {
        Screen.fullScreen = fullscreen.isOn;
        QualitySettings.vSyncCount = vsync.isOn ? 1 : 0;
        Screen.SetResolution(resolutions[selectedResolution].horizontal, resolutions[selectedResolution].vertical, fullscreen.isOn);
    }

    public void ResolutionLeft() {
        selectedResolution--;
        if (selectedResolution < 0) {
            selectedResolution = 0;
        }
        UpdateResolution();
    }

    public void ResolutionRight()
    {
        selectedResolution++;
        if (selectedResolution > resolutions.Length - 1)
        {
            selectedResolution = resolutions.Length - 1;
        }
        UpdateResolution();
    }

    public void UpdateResolution()
    {
        resolutionText.text = resolutions[selectedResolution].formatted();
    }

}


[System.Serializable]
public class ResolutionItem { 
    public int horizontal, vertical;
    public string formatted() 
    { 
        return horizontal.ToString() + " x " + vertical.ToString();
    }
}
