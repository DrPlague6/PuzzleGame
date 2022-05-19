using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WheelTrigger : LevelCondition
{
    bool isPlayerInRange = false;
    [SerializeField] int targetRotationsCount = 0;
    [SerializeField] int stepsCount = 0;
    [SerializeField] GameEvent rotateCheck;
    float targetRotation;
    int stepRotaion;
    Vector3 newRotation;
    
    void OnCollisionEnter(Collision other) => CheckEnter(other.collider);
    void OnCollisionExit(Collision other) => CheckExit(other.collider);
    void OnTriggerEnter(Collider other) => CheckEnter(other);
    void OnTriggerExit(Collider other) => CheckExit(other);
    
    void Start()
    {
        stepRotaion = Mathf.FloorToInt(360 / stepsCount);
        targetRotation = stepRotaion * targetRotationsCount;
        if(targetRotation >= 360)
            targetRotation -= 360;
    }
    void Update()
    {
        if(isPlayerInRange && PlayerInput.Instance.TriggerAction.triggered)
            Rotate(PlayerInput.Instance.TriggerAction.ReadValue<float>());
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
        float rotation = Mathf.Round(transform.localRotation.eulerAngles.z - (direction * stepRotaion));
        transform.eulerAngles = new Vector3(0,0,rotation);
        if(transform.localRotation.eulerAngles.z == targetRotation)
            isConditionMet = true;
        else
            isConditionMet = false;
        Debug.Log(targetRotation);
        Debug.Log(isConditionMet);
        rotateCheck?.Invoke();
    }
}
