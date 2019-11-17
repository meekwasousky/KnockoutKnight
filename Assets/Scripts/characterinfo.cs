using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterinfo : MonoBehaviour
{
    public string characterType;
    public int health;
    public int defense;

    [HideInInspector]
    public string Name;

    public string description;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Knight Projectile"))
        {
            Debug.Log("ATTACK!!!");
            health -= (collision.gameObject.GetComponent<Projectile>().projectileDamage - defense);
            Destroy(collision.gameObject);
        }

        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
