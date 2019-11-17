using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterinfo : MonoBehaviour
{
    public string characterType;
    public float maxHealth;
    public float health;
    public float defense;

    public Slider playerHealthBar;

    [HideInInspector]
    public string Name;

    public string description;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        playerHealthBar.value = CalculateHealth();
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

            playerHealthBar.value = CalculateHealth();

            Destroy(collision.gameObject);
        }

        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private float CalculateHealth()
    {
        return health / maxHealth;
    }
}
