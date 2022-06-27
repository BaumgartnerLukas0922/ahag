using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject playerObject;
    private BoxCollider2D boxCollider;

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
        boxCollider = GetComponent<BoxCollider2D>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 movementVector = playerInputActions.Player.Move.ReadValue<Vector2>();

        movementVector *= new Vector2(Speed/100, Speed/100);
        playerObject.transform.Translate(movementVector);
    }
    

}
