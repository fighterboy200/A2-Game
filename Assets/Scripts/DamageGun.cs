// using UnityEngine;
// using UnityEngine.Events;
// using System.Collections;
// using System.Collections.Generic;

// public class DamageGun : MonoBehaviour
// {
//     public float Damage;
//     public float BulletRange;
//     private Transform PlayerCamera;

//     private void Start()
//     {
//         PlayerCamera = Camera.main.transform;
//     }

//     public void Shoot()
//     {
//         Ray gunRay = new Ray(PlayerCamera.postition, PlayerCamera.forward);

//         if (Physics.Raycast(gunRay, out RaycastHit hitInfo, BulletRange))
//         {
//             if (hitInfo.collider.gameObject.TryGetComponent(out Entity enemy))
//             {
//                 enemy.Health -= Damage;
//             }
//         }
//     }
// }
