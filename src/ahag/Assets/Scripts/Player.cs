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
    

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        
        // for one-tap movements like jumping, special ability (stuff that's not continuous)
        // append a listener-function:
        //playerInputActions.Player.Move.performed += Moved;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ContinuousMovement();
    }

    void ContinuousMovement()
    {
        Vector2 movementVector = playerInputActions.Player.Move.ReadValue<Vector2>();
        movementVector *= new Vector2(0.05f, 0.05f);
        playerObject.transform.Translate(movementVector);
    }
}
