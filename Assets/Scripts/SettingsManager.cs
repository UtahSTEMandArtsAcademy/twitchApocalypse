using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public GameObject mainVolumeSlider;
    public GameObject musicVolumeSlider;
    public GameObject soundEffectSlider;
    
    public void SetResoulution(int size)
    {
        switch (size)
        {
            case 0:
                Screen.SetResolution(640,400,true);
                break;
            case 1:
                Screen.SetResolution(1000,800,true);
                break;
            case 2:
                Screen.SetResolution(1920,1080,true);
                break;
            case 3:
                Screen.SetResolution(3840,2160,true);
                break;
            default:
                Debug.Log("Not a Resolution");
                break;
        }
    }

    public void UpdateVolumes()
    {
        // Update from the slider and then update the playerprefs for the things anyway
        return;
    }
}
