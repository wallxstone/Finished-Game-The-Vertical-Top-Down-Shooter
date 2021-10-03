using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    public Transform playerPosition;
    

    void Start(){
       transform.parent.transform.position = Vector2.Lerp(transform.position, playerPosition.position, 200f * Time.deltaTime);
    }
}
