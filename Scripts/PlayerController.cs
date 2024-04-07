using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    PlayerMove _playerMove = new PlayerMove();
    private Rigidbody rb;
    [SerializeField ]private Animator animator;
    private bool isGrounded = true;
    [SerializeField] private float _jumpForce = 10f;
    private bool IsJumping = false;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * _playerMove._speed * Time.deltaTime;
        transform.Translate(movement);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }

        animator.SetBool("IsJumping", !isGrounded);

    }

    void Jump()
    {
        rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        isGrounded = false;
        IsJumping = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            IsJumping = false;
        }
    }
}