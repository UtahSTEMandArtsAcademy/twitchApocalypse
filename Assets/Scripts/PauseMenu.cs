using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;


public class PauseMenu : MonoBehaviour

{
    public InputActionAsset input;
    private InputAction pause;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        pause = input.FindActionMap("Wizard").FindAction("Pause");
        pause.performed += e =>
        {
            ToggleMenu();
        };

    }

    public void ToggleMenu() 
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
            Time.timeScale = 1;
        }else{
            gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
