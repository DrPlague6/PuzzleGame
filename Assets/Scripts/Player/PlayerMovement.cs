using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] PlayerScript playerScript;
    [SerializeField] CharacterController characterController;
    [SerializeField] Transform Camera;
    private float turnSmoothingVelocity;
    void Update()
    {
        Vector3 movementDirection = new Vector3(PlayerInput.Instance.MovementAction.ReadValue<Vector2>().x, 0,PlayerInput.Instance.MovementAction.ReadValue<Vector2>().y);
        
        if(movementDirection.magnitude <= 0.01f)
            return;
        
        float targetAngle = Mathf.Atan2(movementDirection.x,movementDirection.z) * Mathf.Rad2Deg + Camera.eulerAngles.y;
        float smoothAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y,targetAngle,ref turnSmoothingVelocity, playerScript.PlayerProperties.TurnSmoothingTime);
        transform.rotation = Quaternion.Euler(0f,smoothAngle,0f);

        movementDirection = Quaternion.Euler(0f,targetAngle,0f) * Vector3.forward;
        characterController.Move(movementDirection.normalized * playerScript.PlayerProperties.MovementSpeed * Time.deltaTime);
    }
}