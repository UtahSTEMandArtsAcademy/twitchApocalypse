using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpellCasting : MonoBehaviour
{
    public InputActionAsset input;
    private InputAction basicCast;
    public float basicSpellPerSecond = 2;
    private float basicSpellCoolDown = 0;
    void Awake()
    {
        basicCast = input.FindActionMap("Wizard").FindAction("Basic Cast");
        basicCast.performed += e => {
            Debug.Log("Hit");
            if(basicSpellCoolDown == 0)
            {
                Debug.Log("spell");
                basicSpellCoolDown = 1/basicSpellPerSecond;
            }
        };
    }

    // Update is called once per frame
    void Update()
    {
        basicSpellCoolDown -= Time.deltaTime;
        basicSpellCoolDown = Mathf.Max(basicSpellCoolDown - Time.deltaTime, 0);
    }
}
