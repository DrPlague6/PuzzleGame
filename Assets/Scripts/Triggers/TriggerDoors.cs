using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoors : MonoBehaviour
{
    [SerializeField] GameEvent _triggerDors;
    void OnColliderEnter(Collider other){
        if(other.tag != "Player" || other.tag != "Pushable")
            return;
        _triggerDors?.Invoke();
    }
}
