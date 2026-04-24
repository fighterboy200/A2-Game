using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PistolScript : MonoBehaviour
{
    [SerializeField] public LayerMask EnemyAILayer;

    [SerializeField] public LayerMask IgnoreLayer;

    [SerializeField] private float damage = 50f;

    
    public Camera playerCam;

    void Start()
    {
        playerCam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("left click");
            
            Ray gunray = new Ray(playerCam.transform.position, playerCam.transform.forward);

            if (Physics.Raycast(gunray, out RaycastHit hitInfo, 100f, EnemyAILayer))
            {
                Debug.Log("Enemy Hit");

                if (hitInfo.collider.gameObject.TryGetComponent(out EnemyHealth enemyHit))
                {
                    enemyHit.SubtractHealth(damage);
                    Debug.Log(enemyHit.health);
                }
            }
        }
    }
}
