using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostController : MonoBehaviour
{
   Player playerInstance;
   public float boostDuration;
   void Awake(){
       playerInstance = FindObjectOfType<Player>();
       boostDuration = 5f;
   }
    void Update(){
        if(playerInstance.isBoosted){
            boostDuration -= Time.deltaTime;
        } else if(boostDuration <= 0) playerInstance.isBoosted = false;
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player")){
            BoostPlayer();
        }
    }

   void BoostPlayer(){
       if(boostDuration >= 0) playerInstance.isBoosted = true;
       if(playerInstance.isBoosted) playerInstance.GetComponent<PlayerMovement>().moveSpeed *=  2;
   }
}
