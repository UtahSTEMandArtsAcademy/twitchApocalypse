using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class WizardMovement : MonoBehaviour
{
   public InputActionAsset input;
   public float moveSpeed;
   public float damping;
   public InputAction move;
    private Rigidbody rb;
    
    void Awake()
    {
        input.FindActionMap("Wizard").Enable();
        move = input.FindActionMap("Wizard").FindAction("Move");
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector2 moveInput = move.ReadValue<Vector2>();
        //Debug.Log(moveInput);
        rb.AddForce(new Vector3(moveInput.x, 0, moveInput.y) * moveSpeed * Time.deltaTime);

    }
}
