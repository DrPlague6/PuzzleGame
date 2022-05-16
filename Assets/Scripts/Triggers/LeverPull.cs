using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverPull : MonoBehaviour
{
    [SerializeField] GameEvent _leverPull;
    private bool isPlayerInRange;
    void OnCollisionEnter(Collision other) => CheckEnter(other.collider);
    void OnCollisionExit(Collision other) => CheckExit(other.collider);
    void OnTriggerEnter(Collider other) => CheckEnter(other);
    void OnTriggerExit(Collider other) => CheckExit(other);
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
    void Update(){
        if(Input.GetKeyDown(KeyCode.E) && isPlayerInRange)
            _leverPull?.Invoke();
    }
}
