﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RPG.Characters
{
    public class EnemyHealthBar : MonoBehaviour
    {
        RawImage healthBarRawImage = null;
        Enemy enemy = null;

        void Start()
        {
            enemy = GetComponentInParent<Enemy>();
            healthBarRawImage = GetComponent<RawImage>();
        }

        void Update()
        {
            float xValue = -(enemy.healthAsPercentage / 2f) - 0.5f;
            healthBarRawImage.uvRect = new Rect(xValue, 0f, 0.5f, 1f);
        }
    }
}