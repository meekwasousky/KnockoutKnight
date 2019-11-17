using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    protected CharacterController controller1;
    public float speed;
    public bool animation_bool;
    public Animator anim;
    public GameObject projectile;
                  
    // Start is called before the first frame update
    void Start()
    {
        controller1 = gameObject.GetComponent<CharacterController>();
        speed = 1.5f;
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetTrigger("Attacking");
            ThrowProjectile();
        }
    }

    public void playerMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    public void ThrowProjectile()
    {
        GameObject clone;
        clone = Instantiate(projectile, this.gameObject.transform.GetChild(0).position, this.gameObject.transform.GetChild(0).rotation) as GameObject;
        Destroy(clone, 5.0f);
    }
}
