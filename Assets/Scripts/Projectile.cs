using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 2.0f;

    public bool player1;
    
    public float projectileDamage;

    void start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player1 == true)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}