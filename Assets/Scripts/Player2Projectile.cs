﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Projectile : MonoBehaviour
{
    public float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
