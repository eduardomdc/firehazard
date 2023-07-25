using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPerna : MonoBehaviour
{
    //Velocidade do Player
    public float speed;
    //Velocidade da rotação das pernas do Player
    [SerializeField] 
    private float rotationSpeed;
    // Resultado da matemática em relação a velocidade de movimento do Player
    [SerializeField] 
    Vector2 moveSpeed;
    //RigBody2D do Player para fazer os cálculos em relação a movimentação das pernas
    [SerializeField] 
    private Rigidbody2D Player;
    //Animator para controlar a animação das pernas
    [SerializeField]
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //Coleta o RigidBody2D e o animator
        Player = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 PlayerInput = new(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveSpeed = PlayerInput.normalized * speed;
        Player.MovePosition(Player.position + moveSpeed * Time.fixedDeltaTime);
        //Rotação das pernas do Player e checagens para o animador se ele está andando ou não
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
}
