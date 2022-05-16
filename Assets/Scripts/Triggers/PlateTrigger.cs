using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateTrigger : MonoBehaviour
{
    [SerializeField] GameEvent _triggerDoors;
    void OnTriggerEnter(Collider other){
        Debug.Log("Collided");      
        Debug.Log(other.gameObject.tag);
        Debug.Log(other.gameObject.name);
        if(other.gameObject.tag != "Player" && other.gameObject.tag != "Pushable"){
            Debug.Log("Not Player");
            return;
        }
        _triggerDoors.Invoke();
    }
}
