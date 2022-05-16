using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController _characterController;
    [SerializeField] PlayerObject _playerObject;
    public Transform Camera;
    private float _inputVerticalAxis;
    private float _inputHorizontalAxis;
    private float _turnSmoothingVelocity;
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _inputVerticalAxis = Input.GetAxis("Vertical");
        _inputHorizontalAxis = Input.GetAxis("Horizontal");
        
        Vector3 movementDirection = new Vector3(_inputHorizontalAxis, 0,_inputVerticalAxis);
        
        if(movementDirection.magnitude <= 0.01f)
            return;
        
        float targetAngle = Mathf.Atan2(movementDirection.x,movementDirection.z) * Mathf.Rad2Deg + Camera.eulerAngles.y;
        float smoothAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y,targetAngle,ref _turnSmoothingVelocity, _playerObject.TurnSmoothingTime);
        transform.rotation = Quaternion.Euler(0f,smoothAngle,0f);

        movementDirection = Quaternion.Euler(0f,targetAngle,0f) * Vector3.forward;
        _characterController.Move(movementDirection.normalized * _playerObject.MovementSpeed * Time.deltaTime);
    }
}
