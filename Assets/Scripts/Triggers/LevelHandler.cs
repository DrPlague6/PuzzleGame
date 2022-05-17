using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelHandler : MonoBehaviour
{

    [SerializeField] GameEvent levelCompleteEvent;
    [SerializeField] List<GameObject> conditionList = new List<GameObject>();
    void Start(){
        
    }
    public void CheckConditions(){
        foreach(GameObject condition in conditionList)
            if(!condition.GetComponent<LevelCondition>().IsConditionMet)
                return;
        levelCompleteEvent?.Invoke();
    }
}
