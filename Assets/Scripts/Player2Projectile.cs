using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Projectile : MonoBehaviour
{
    public float speed = 2.0f;

    public int projectileDamage;

    void start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    void OnCollisionEnter2d(Collision2D collision)
    {
        if (collision.gameObject.tag == "Knight" || collision.gameObject.tag == "Paladin" || collision.gameObject.tag == "Defender")
        {
            collision.gameObject.GetComponent<characterinfo>().health -= (projectileDamage - collision.gameObject.GetComponent<characterinfo>().defense);
            Destroy(this.gameObject);
            Debug.Log("P1 has been hit!");
        }
    }
}