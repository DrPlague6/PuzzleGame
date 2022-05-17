using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LevelCondition : MonoBehaviour
{
    protected bool isConditionMet;
    public bool IsConditionMet{
        get => isConditionMet;
    }
}
