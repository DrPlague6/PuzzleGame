using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTrigger : MonoBehaviour
{   
    [SerializeField] Transform spawnPoint;
    [SerializeField] GameEvent lockDoors;
    void OnCollisionEnter(Collision other) => Check(other.collider);
    void OnTriggerEnter(Collider other) => Check(other);
    void Check(Collider other){
        if(other.gameObject.tag != "Player")
            return;
        other.transform.position = new Vector3(spawnPoint.position.x, other.transform.position.y, spawnPoint.position.z);
        lockDoors?.Invoke();
    }
}
