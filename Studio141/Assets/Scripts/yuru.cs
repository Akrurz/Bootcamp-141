using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yuru : MonoBehaviour
{
    float speed = 2.5f;
    float rotspeed = 80;
    float gravity = 8;
    float rot = 0;
    Vector3 moveDir = Vector3.zero;

    CharacterController kontrol;
    Animator anim;
    void Start()
    {
        kontrol = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (kontrol.isGrounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                moveDir = new Vector3(0, 0, 1);
                moveDir *= speed;
                anim.SetInteger("hareket", 1);
                moveDir = transform.TransformDirection(moveDir);
            }
            else
            {
                moveDir = new Vector3(0, 0, 0);
                anim.SetInteger("hareket", 0);
            }
        }
        rot += Input.GetAxis("Horizontal") * rotspeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);
        moveDir.y -= gravity * Time.deltaTime;
        kontrol.Move(moveDir * Time.deltaTime);
    }
}
