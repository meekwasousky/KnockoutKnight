using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Projectile : MonoBehaviour
{
    public float speed = 2.0f;
    
    public int projectileDamage;

    void start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void OnCollisionEnter2d(Collision2D collision)
    {
        if (collision.gameObject.tag == "Knight P2" || collision.gameObject.tag == "Paladin P2" || collision.gameObject.tag == "Defender P2")
        {
            collision.gameObject.GetComponent<characterinfo>().health -= (projectileDamage - collision.gameObject.GetComponent<characterinfo>().defense);
            Debug.Log("P2 has been hit!");
        }
    }
}
