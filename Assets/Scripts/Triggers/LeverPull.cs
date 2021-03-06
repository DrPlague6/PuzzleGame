using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverPull : LevelCondition
{
    [SerializeField] Animator leverAnimator;
    [SerializeField] GameEvent leverPullEvent;
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
        if(PlayerInput.Instance.TriggerAction.triggered  && isPlayerInRange)
            LeverPulled();
    }
    void LeverPulled(){
        if(!IsConditionMet){
            isConditionMet = true;
            leverPullEvent?.Invoke();
            leverAnimator.SetFloat("Direction",1.0f);
            leverAnimator.Play("MoveDown");
            return;
        }
        leverAnimator.SetFloat("Direction",-1.0f);
        leverAnimator.Play("MoveUp");
    }
}
