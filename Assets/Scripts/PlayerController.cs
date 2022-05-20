using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;

    private float speed = 7f;
    private float gravity = -9.81f;
    private float jumpHeight = 3f;

    public Transform groundCheck;
    private float groundDistance = 0.4f;
    public LayerMask groundmask;

    Vector3 velocity;
    bool isGrounded;

    private float health = 3.0f;
    public GameManager gameManager;

    void Update()
    { 
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundmask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (gameObject.CompareTag("Enemy"))
        {
            gameManager.GameOver(); 
        }
    }
}
