using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Player Object",menuName = "Entity/Player")]
public class PlayerObject : ScriptableObject
{
    public float MovementSpeed;
    public float TurnSmoothingTime;
}
