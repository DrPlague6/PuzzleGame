using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateTrigger : MonoBehaviour
{
    [SerializeField] GameEvent _triggerDoors;
    [SerializeField] Animation plateAniamtion;
    HashSet<int> triggersIn = new HashSet<int>();
    void OnTriggerEnter(Collider other) => CheckEnter(other);
    void OnTriggerExit(Collider other) => CheckExit(other);
    void OnCollisionEnter(Collision other) => CheckEnter(other.collider);
    void OnCollisionExit(Collision other) => CheckEnter(other.collider);
    private void CheckEnter(Collider other){
        if(other.gameObject.tag != "Pushable")
            return;
        _triggerDoors.Invoke();
        triggersIn.Add(other.gameObject.GetHashCode());
        if(triggersIn.Count > 1)
            return;
        plateAniamtion["PlatePushed"].speed = 1;
        plateAniamtion.Play();
    }
    private void CheckExit(Collider other){
        triggersIn.Remove(other.gameObject.GetInstanceID());
        if(triggersIn.Count != 0)
            return;
        plateAniamtion["PlatePushed"].speed = -1f;
        plateAniamtion.Play();    
    }
}
