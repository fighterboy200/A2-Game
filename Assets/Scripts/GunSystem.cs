// using UnityEngine;
// using System.Collections;
// using System.Collections.Generic;

// public class GunSystem : MonoBehaviour
// {
//     //Gun Stats

//     public int damage;
//     public float timeBetweenShooting, spread, range, reloadTime, timeBetweenShots;
//     public int magazineSize, bulletsPerTap;
//     public bool allowButtonHold;
//     int bulletsLeft, bulletsShot;

//     //bools
//     bool shooting, readyToShoot, reloading;

//     //References
//     public Camera cam;
//     public Transform attackPoint;
//     public RaycastHit rayHit;
//     public LayerMask whatIsEnemy;

//     public void Awake()
//     {
//         bulletsLeft = magazineSize;
//         readyToShoot = true;
//     }

//     public void Update()
//     {
//         MyInput();
//     }

//     public void MyInput()
//     {
//         if (allowButtonHold) shooting = Input.GetMouseButton(0);
//         else shooting = Input.GetMouseButtonDown(0);

//         if (Input.GetKeyDown(KeyCode.R) && bulletsLeft < magazineSize && !reloading)
//         {
//             Reload();
//         }

//         //Shoot
//         if (readyToShoot && shooting && !reloading && bulletsLeft > 0)
//         {
//             bulletsShot = bulletsPerTap;

//             Shoot();
//         }
//     }

//     public void Shoot()
//     {
//         readyToShoot = false;

//         //Spread
//         float x = Random.Range(-spread, spread);
//         float y = Random.Range(-spread, spread);

//         //Calculate Direction with Spread
//         Vector3 direction = cam.transform.forward + new Vector3(x, y, 0);

//         //Raycast
//         if (Physics.Raycast(cam.transform.position, direction, out rayHit, range, whatIsEnemy))
//         {
//             Debug.Log(rayHit.collider.name);

//             // if (rayHit.collider.CompareTag("Enemy"))
//             //     rayHit.collider.GetComponent<ShootingAi>().TakeDamage(damage);
//         }

//         bulletsLeft--;
//         bulletsShot--;
//         Invoke("ResetShot", timeBetweenShooting);

//         if (bulletsShot > 0 && bulletsLeft > 0)
//         Invoke("Shoot", timeBetweenShots);
//     }

//     public void ResetShot()
//     {
//         readyToShoot = true;
//     }

//     public void Reload()
//     {
//         reloading = true;
//         Invoke("ReloadFinished", reloadTime);
//     }

//     public void ReloadFinished()
//     {
//         bulletsLeft = magazineSize;
//         reloading = false; 
//     }
// }
