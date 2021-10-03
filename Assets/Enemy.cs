using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float attackRange;
    public float damage;
    public float timeToAtk;
    public float moveSpeed;
    void Awake(){
        moveSpeed = 10f;
        timeToAtk = 3f;
        damage = 2f;
        attackRange = 5f;
    }
    
}
