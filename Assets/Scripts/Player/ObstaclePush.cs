using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePush : MonoBehaviour
{
    [SerializeField] PlayerScript playerScript;
    void OnControllerColliderHit(ControllerColliderHit other){
        Rigidbody rb = other.collider.attachedRigidbody;
        if(other.gameObject.tag != "Pushable")
            return;
        if(rb == null || rb.isKinematic)
            return;
        rb.velocity = other.moveDirection * playerScript.PlayerProperties.Strength;
    }
}
