﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Projectile : MonoBehaviour
{
    public float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
