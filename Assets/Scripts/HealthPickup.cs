// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class HealthPickup : MonoBehaviour
// {
//     Player playerHealth;

//     public int healthBonus = 10;

//     void Awake()
//     {
//         playerHealth = FindObjectOfType<Player>();
//     }

//     void Start() {
//         print(playerHealth.currentHealth);
//     }

//     void OnTriggerEnter(Collider col)//playerHealth.currentHealth < playerHealth.maxHealth
//     {
//         if(playerHealth.currentHealth < playerHealth.maxHealth)
//         {
            
//             Destroy(gameObject);
//             playerHealth.currentHealth += healthBonus;
            
//         }
//     }   
// }
