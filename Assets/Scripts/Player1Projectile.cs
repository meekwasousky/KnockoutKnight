using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Projectile : MonoBehaviour
{
    public float speed = 2.0f;
    
    public int knightDamage;
    public int paladinDamage;
    public int defenderDamage;

    private int projectileDamage;

    void start()
    {
        knightDamage = 10;
        paladinDamage = 8;
        defenderDamage = 6;
        if(this.gameObject.tag == "Paladin Projectile")
        {
            projectileDamage = paladinDamage;
        }
        if(this.gameObject.tag == "Knight Projectile")
        {
            projectileDamage = knightDamage;
        }
        if(this.gameObject.tag == "Defender Projectile")
        {
            projectileDamage = defenderDamage;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void OnCollisionEnter2d(Collision2D collision)
    {
        if(collision.gameObject.tag == "Knight P2")
        {
            
        }
    }
}
