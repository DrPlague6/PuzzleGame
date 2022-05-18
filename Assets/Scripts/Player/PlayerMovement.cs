using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] PlayerScript playerScript;
    [SerializeField] CharacterController _characterController;
    public Transform Camera;
    private float inputVerticalAxis;
    private float inputHorizontalAxis;
    private float turnSmoothingVelocity;
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementDirection = new Vector3(playerScript.MovementVector.x, 0,playerScript.MovementVector.y);
        
        if(movementDirection.magnitude <= 0.01f)
            return;
        
        float targetAngle = Mathf.Atan2(movementDirection.x,movementDirection.z) * Mathf.Rad2Deg + Camera.eulerAngles.y;
        float smoothAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y,targetAngle,ref turnSmoothingVelocity, playerScript.playerProperties.TurnSmoothingTime);
        transform.rotation = Quaternion.Euler(0f,smoothAngle,0f);

        movementDirection = Quaternion.Euler(0f,targetAngle,0f) * Vector3.forward;
        _characterController.Move(movementDirection.normalized * playerScript.playerProperties.MovementSpeed * Time.deltaTime);
    }
}
