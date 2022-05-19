using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] PlayerObject playerProperties;
    public PlayerObject PlayerProperties {get => playerProperties;}
}