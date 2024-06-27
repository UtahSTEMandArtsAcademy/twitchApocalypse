using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Singleton { get { if (_singleton == null) _singleton = FindAnyObjectByType<GameManager>(); return _singleton; }}
    private static GameManager _singleton;

    void Awake()
    {
        if (_singleton != null && _singleton != this)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this);
    }
    
    public void Quit()
    {
        Application.Quit();
    }

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
        }//640x400
        //1000x800
        //1920x1080
        //3840x2160
    }
}
