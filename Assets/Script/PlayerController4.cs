using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController4 : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float rotateSpeed = 3.0f;
    private Vector3 moveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        Move();
    }

    // Update is called once per frame
    void Move()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(0, 0, TouchControls.playerMoveAxisTouch);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        // rotating Player along y axis
        transform.Rotate(0, TouchControls.playerTurnAxisTouch, 0);
    }
}
