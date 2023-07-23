using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPerna : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField] 
    private float rotationSpeed;

    [SerializeField] 
    Vector2 moveSpeed;
     
    [SerializeField] 
    private Rigidbody2D Player;

    [SerializeField]
    private Animator animator;
   /*  public float moveSpeed = 3.4f;
    public float rotationSpeed;
    public Vector2 moveDirection;
    public Rigidbody2D rb;
    private Animator anim; */

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 PlayerInput = new(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveSpeed = PlayerInput.normalized * speed;
        Player.MovePosition(Player.position + moveSpeed * Time.fixedDeltaTime);
        if (PlayerInput != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, PlayerInput);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            animator.SetBool("walk", true);
        }
        if (PlayerInput.x == 0 && PlayerInput.y == 0)
        {
            animator.SetBool("walk", false);
        }
    }
    void FixedUpdate()
    {
        //SetPlayerVelocity();
        /*float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical"); 
        moveDirection = new Vector2(moveX,moveY).normalized;
        float inputMagnitude = Mathf.Clamp01(moveDirection.magnitude);
        transform.Translate(moveDirection * moveSpeed * inputMagnitude* Time.deltaTime, Space.World);
        
        if (moveDirection != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, moveDirection);
            Quaternion rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed *
            Time.deltaTime);
            rb.MoveRotation(rotation)
        }
        */
        //CheckAnimation();
    }
    private void SetPlayerVelocity()
    {
        //_smoothedMovementInput = Vector2.SmoothDamp(_smoothedMovementInput, _movementInput,
        //ref _movementInputSmoothVelocity);
    }
    void CheckAnimation()
    {
    /*if (movementDirection != 0f || rigidBody.velocityY != 0f)
    {
        print("Meu deus");
        animator.SetBool("walk", true);
    }
      if (rigidBody.velocityX == 0f && rigidBody.velocityY == 0f)
    {
        print("Foi porra");
        animator.SetBool("walk", false);
    }
    }
    /* void move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    */
    }
}
