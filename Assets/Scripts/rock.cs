using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
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
            Destroy(collision.gameObject);
        }
    }
}
