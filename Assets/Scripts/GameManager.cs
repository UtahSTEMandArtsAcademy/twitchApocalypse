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
}
