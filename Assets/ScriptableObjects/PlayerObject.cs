using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Player Object",menuName = "Entity/Player")]
public class PlayerObject : ScriptableObject
{
    [SerializeField] float movementSpeed;
    [SerializeField] float turnSmoothingTime;
    public float MovementSpeed {
        get => movementSpeed;
    }
    public float TurnSmoothingTime{
        get => turnSmoothingTime;
    }
}
