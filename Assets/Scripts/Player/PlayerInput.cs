using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private static PlayerInput instance;
    public static PlayerInput Instance {
        get => instance;
    }
    private DefaultInput playerInput;
    private InputAction movementAction;
    private InputAction triggerAction;
    public InputAction MovementAction{
        get => movementAction;
    }
    public InputAction TriggerAction{
        get => triggerAction;
    }
    void Awake(){
        if(instance != null && instance != this){
            Destroy(this);
            return;
        }
        instance = this;
        playerInput = new DefaultInput();
        movementAction = playerInput.Walking.Movement;
        triggerAction = playerInput.Walking.Turn;
    }
    void OnEnable(){
        movementAction.Enable();
        triggerAction.Enable();
    }
    void OnDisable(){
        movementAction.Disable();
        triggerAction.Disable();
    }
}