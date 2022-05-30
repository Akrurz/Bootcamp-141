using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Character_Controller : MonoBehaviour
{

    Animator anim;
    float random = 0f;
    Rigidbody rgb;
    public float moveSpeed = 10f;
    public Vector2 moveVal;
    bool run = false;
    void Start()
    {
        anim = GetComponent<Animator>();
        rgb = GetComponent<Rigidbody>();
        randomIdle();
        
    }

   
    void Update()
    {
        
    }


    public void randomIdle()
    {
        random = Random.Range(0f, 1f);
        anim.SetFloat("RandomIdle", random);
    }

    public void Move(InputAction.CallbackContext value)
    {
        if (value.performed)
        {
           
            moveVal = value.ReadValue<Vector2>();
            anim.SetBool("Move", true);
            anim.SetFloat("Movement", moveVal.y);
            anim.SetFloat("MovementDirection", moveVal.x);
            Debug.Log(moveVal.y);
            run = true;
            //Debug.Log(moveVal.x + " " + moveVal.y);
            //rgb.transform.position += new Vector3(moveVal.x * moveSpeed * Time.deltaTime, 0, moveVal.y * moveSpeed * Time.deltaTime);
        }

        if (value.canceled)
        {
            moveVal = value.ReadValue<Vector2>();
            randomIdle();
            anim.SetBool("Move", false);
            anim.SetFloat("Movement", moveVal.y);
            anim.SetFloat("MovementDirection", moveVal.x);
            run = false;
        }

    }

    public void Run(InputAction.CallbackContext value)
    {
        if (value.performed && moveVal.y >= 0.6f)
        {
            moveVal += new Vector2(0, 1);
            Debug.Log(moveVal.magnitude);
            anim.SetFloat("Movement", moveVal.y);
            Debug.Log("shift");
        }
        if (value.canceled && moveVal.y >= 0.6f)
        {
            moveVal -= new Vector2(0, 1);
            anim.SetFloat("Movement", moveVal.y);
            Debug.Log("shift");
        }
    }
}
