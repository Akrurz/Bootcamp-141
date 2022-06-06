using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{

    Character_Controller movement;
    CharacterController controller;
    [SerializeField] float dampTime;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        movement = GetComponent<Character_Controller>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        controller.Move(new Vector3(movement.moveVal.x*movement.moveSpeed/dampTime,0,movement.moveVal.y*movement.moveSpeed/dampTime));
    }
}
