using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
   public float damage;
   public float range;
   public Transform barrel;
   public GameObject bullet;
   public GameObject currentBullet;
   public bool isReloading;
   public float bulletDuration;
   public int bulletCount;
   void Start(){
       bulletDuration = 10f;
   }
   void Update(){
       if(transform.parent != null){
        if(Input.GetMouseButtonDown(0) && bulletCount <= 10) GenerateMagazine();
        if(currentBullet != null){
           Bullet();
         }
       }
   }
   
   void Bullet(){
       currentBullet.transform.position += (Vector3.up * 10f) * Time.deltaTime;
       bulletDuration -= Time.deltaTime;
       if(bulletDuration <= 0 ) {
           GameObject.Destroy(currentBullet);
           bulletCount--;
           bulletDuration = 10f;
       }
       
   }
   void GenerateMagazine(){
        currentBullet = Instantiate(bullet,barrel.position,Quaternion.identity);
        bulletCount++;
   }
}
