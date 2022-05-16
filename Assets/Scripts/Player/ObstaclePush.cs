using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePush : MonoBehaviour
{
    [SerializeField] float _pushForce;
    void OnControllerColliderHit(ControllerColliderHit other){
        Rigidbody rb = other.collider.attachedRigidbody;
        if(other.gameObject.tag != "Pushable")
            return;
        if(rb == null || rb.isKinematic)
            return;
        else
            rb.velocity = other.moveDirection * _pushForce;
    }
}
