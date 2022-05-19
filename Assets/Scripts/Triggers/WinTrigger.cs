using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    [SerializeField] GameEvent winEvent;
    void OnTriggerEnter(Collider other){
        Check(other);
    }
    void OnCollisionEnter(Collision other){
        Check(other.collider);
    }
    void Check(Collider other){
        if(other.gameObject.tag != "Player")
            return;
        Debug.Log("WIN!");
        winEvent?.Invoke();
    }
}
