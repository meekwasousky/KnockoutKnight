using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    protected CharacterController controller2;
    public float speed;
    public bool animation_bool;
    public Animator anim;
                  
    // Start is called before the first frame update
    void Start()
    {
        controller2 = gameObject.GetComponent<CharacterController>();
        speed = 1.5f;
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
        if(Input.GetKey(KeyCode.Mouse1))
        {
            anim.SetTrigger("Attacking");
        }
    }

    public void playerMovement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

}
