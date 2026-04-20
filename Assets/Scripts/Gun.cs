// using UnityEngine;
// using UnityEngine.Events;
// using System.Collections;
// using System.Collections.Generic;

// public class Gun : MonoBehaviour
// {
//     public UnityEvent onGunShoot;
//     public float fireCooldown;

//     public bool Automatic;

//     private float currentCooldown;

//     void Start()
//     {
//         currentCooldown = fireCooldown;
//     }

//     void Update()
//     {
//         if (Automatic)
//         {
//             if (Input.GetMouseButton(0))
//             {
//                 if (currentCooldown <= 0f)
//                 {
//                     onGunShoot?.Invoke();
//                     currentCooldown = fireCooldown;
//                 }
//             }
//         }
//         else
//         {
//             if (Input.GetMouseButton(0))
//             {
//                 if (currentCooldown <= 0f)
//                 {
//                     onGunShoot?.Invoke();
//                     currentCooldown = fireCooldown;
//                 }
//             }
//         }

//         currentCooldown -= Time.deltaTime;
//     }
// }
