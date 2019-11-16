using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{
    private int durability = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Defender Projectile") || collision.gameObject.CompareTag("Knight Projectile") || collision.gameObject.CompareTag("Paladin Projectile"))
        {
            durability -= 1;
            Destroy(collision.gameObject);
        }
        if(durability<= 0){
            Destroy(this.gameObject);
        }
    }
}
