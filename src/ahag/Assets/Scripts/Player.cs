using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject playerObject;

    private InputActionAsset actions;
    private PlayerInputActions playerInputActions;

    [Tooltip("Speed")]
    public float Speed;


    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        //playerInputActions.Player.Move.performed += Moved;
    }

    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 movementVector = playerInputActions.Player.Move.ReadValue<Vector2>();
        movementVector *= new Vector2(Speed/500, Speed/500);
        playerObject.transform.Translate(movementVector);
    }
}
