using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WheelTrigger : LevelCondition
{
    bool isPlayerInRange = false;
    [SerializeField] private int targetRotationsCount = 0;
    [SerializeField] private int stepsCount = 0;
    [SerializeField] private GameEvent rotateCheck;
    private float targetRotation;
    private float stepRotaion;
    private Vector3 newRotation;
    private DefaultInput playerInput; 
    private InputAction triggerInput;

    
    void OnCollisionEnter(Collision other) => CheckEnter(other.collider);
    void OnCollisionExit(Collision other) => CheckExit(other.collider);
    void OnTriggerEnter(Collider other) => CheckEnter(other);
    void OnTriggerExit(Collider other) => CheckExit(other);
    
    void Awake(){
        playerInput = new DefaultInput();
        triggerInput = playerInput.Walking.Turn;
    }
     void OnDisable(){
        triggerInput.Disable();
    }
    void OnEnable(){
        triggerInput.Enable();
    }
    
    void Start()
    {
        stepRotaion = Mathf.Floor(360 / stepsCount);
        targetRotation = stepRotaion * targetRotationsCount;
    }
    void Update()
    {
        if(triggerInput.triggered && isPlayerInRange)
            Rotate(triggerInput.ReadValue<float>());
    }
    void CheckEnter(Collider other){
        if(other.gameObject.tag != "Player")
            return;
        isPlayerInRange = true;
    }
    void CheckExit(Collider other){
        if(other.gameObject.tag != "Player")
            return;
        isPlayerInRange = false;
    }
    public void Rotate(float direction){
        newRotation = new Vector3(0,0,transform.localRotation.eulerAngles.z + (direction * stepRotaion));
        transform.eulerAngles = newRotation;
        if(newRotation.z == targetRotation)
            isConditionMet = true;
        else
            isConditionMet = false;
        Debug.Log(isConditionMet);  
        rotateCheck?.Invoke();
    }
}
