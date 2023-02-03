using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.EventSystems;

public class CharacterController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    public Vector3 moveDirection;
    [SerializeField] Vector3 moveVector; //temp serializefield
    CameraBehaviour camBehave;
    Animator animator;

    float hMove;
    float vMove;

    Rigidbody rb;
    bool isMoving;
    bool isRolling;


    void Start()
    {
        camBehave = GameObject.Find("Main Camera").GetComponent<CameraBehaviour>();
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        GetMoveDirection();
        Animate();

    }

    void FixedUpdate()
    {
        if (isMoving)
        {
            Walk();
        }
    }

    void GetMoveDirection()
    {
        hMove = Input.GetAxisRaw("Horizontal");
        vMove = Input.GetAxisRaw("Vertical");

        moveDirection = camBehave.camTrans.rotation * new Vector3(hMove, 0, vMove).normalized * moveSpeed;
        transform.rotation = Quaternion.Euler(0, camBehave.camTrans.rotation.y, 0);
        //moveDirection = new Vector3(hMove, 0, vMove).normalized * moveSpeed;
        isMoving = true;
    }
    public void Walk()
    {

        rb.velocity = new Vector3(moveDirection.x, rb.velocity.y, moveDirection.z);

    }

    void Animate()
    {
        if (moveDirection == Vector3.zero)
        {
            animator.SetBool("Walk_Anim", false);
        }
        else if (moveDirection != Vector3.zero)
        {
            animator.SetBool("Walk_Anim", true);
        }
    }
}
