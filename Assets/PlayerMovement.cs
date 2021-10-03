using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    
    void Update(){
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        
    }   
    

    void OnDrawGizmos(){
        Debug.DrawRay(transform.position, Vector3.up, new Color(0,255,0));
    }
}

