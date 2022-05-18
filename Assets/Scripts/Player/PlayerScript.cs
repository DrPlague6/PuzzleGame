using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public PlayerObject playerProperties;
    private DefaultInput playerInput; 
    private  InputAction walkingInput;
    private Vector2 movementVector;
    public Vector2 MovementVector{
        get => movementVector;
    }
    void Awake(){
        playerInput = new DefaultInput();
        walkingInput = playerInput.Walking.Movement;
    }
    // Update is called once per frame
    void OnDisable(){
        walkingInput.Disable();
    }
    void OnEnable(){
        walkingInput.Enable();
    }
    void Update(){
        movementVector = walkingInput.ReadValue<Vector2>();
    }
}