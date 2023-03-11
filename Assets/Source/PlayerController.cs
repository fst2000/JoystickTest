using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    IMoveSystem moveSystem;
    [SerializeField] float moveSpeed;
    [SerializeField] JoystickController controller;
    void Start()
    {
        moveSystem = new RigidBodyMoveSystem(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        moveSystem.Move(controller,moveSpeed);
    }
}
