using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PauseMenu : MonoBehaviour

{
    public InputActionAsset input;
    public InputAction pause;

    // Start is called before the first frame update
    void Start()
    {
        pause = input.FindActionMap("Wizard").FindAction("Pause");
        pause.performed += e =>
        {
                       
        };

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
