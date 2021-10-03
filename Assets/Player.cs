using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health;
    public GameObject equippedWeapon;
    public bool hasWeapon;
    public bool isBoosted;
    public bool canEquip;
    public Transform fwdDir;

    public static Player instance;
    public void Awake(){
        instance = this;
    }
    void Start(){
        hasWeapon = false;
        isBoosted = false;
        canEquip = true;
    }
   void Update(){
      if(Input.GetKeyDown(KeyCode.E)) InteractWithDoor();
   }

    void InteractWithDoor(){
        RaycastHit2D hit = Physics2D.Raycast(fwdDir.position, Vector3.up);
        if(hit.collider.CompareTag("Door")){
            Debug.Log("Door opened");
            hit.collider.gameObject.SetActive(false);
        } else {
            Debug.Log("Door's no longer infront");
        }
        Debug.Log(hit.collider);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Weapon") && canEquip && !isBoosted) {
            equippedWeapon = other.gameObject;
            hasWeapon = true;
            canEquip = false;
            other.gameObject.transform.SetParent(transform,true);
        }
        if(other.CompareTag("Boost") && canEquip){
                other.gameObject.SetActive(false);
                isBoosted = true;
                canEquip = false;
            }
            
        if(other.CompareTag("Enemy")) Vector2.Lerp(other.transform.position, transform.position, 2f);
    }
    void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Checkpoint")) other.isTrigger = false;
    }
}