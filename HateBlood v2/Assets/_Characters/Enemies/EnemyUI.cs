﻿using UnityEngine;

namespace RPG.Characters
{
    public class EnemyUI : MonoBehaviour
    {

        [Tooltip("The UI canvas prefab")]
        [SerializeField]
        GameObject enemyCanvasPrefab = null;

        Camera cameraToLookAt;

        
        void Start()
        {
            cameraToLookAt = Camera.main;
            Instantiate(enemyCanvasPrefab, transform.position, Quaternion.identity, transform);
        }

        void LateUpdate()
        {
            transform.LookAt(cameraToLookAt.transform);
        }
    }
}