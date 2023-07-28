using System.Collections;
using System.Collections.Generic;
using MangoFog;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    //Esse código não ta sendo mais usado no momento mas deixei aqui por precaução 
    public float moveSpeed = 5f;

    public Rigidbody2D rb, rig;

    //public Extintor extintor;
    public Vector2 moveDirection;
    public Vector2 mousePosition;


    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        var moveX = Input.GetAxisRaw("Horizontal");
        var moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
        var aimDirection = mousePosition - rb.position;
        var aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
    }
    /* void move()
    {
       float moveX = Input.GetAxisRaw("Horizontal");
       float moveY = Input.GetAxisRaw("Vertical"); 
       if (Input.GetAxis("Horizontal") >0f || (Input.GetAxis("Vertical") > 0f))
       {
           anim.SetBool("walk", true);
       }

       moveDirection = new Vector2(moveX,moveY).normalized;
       mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    } */
}