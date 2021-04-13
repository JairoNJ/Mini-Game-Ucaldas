using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;
    public float maxSpeed = 10f;
    public bool isFloor;
    public float radio = 0.8f;
    public LayerMask floor;
    public Transform pie;
    public float maxJump = 40f;

    public Transform Player;
    public float posX;

    public Vector2 screenBouns;
    public Vector3 posPlayer;

   


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        posPlayer = this.transform.position;
        DirectionPlayer();
        JumpPlayer();
        ScreenPosition();
        Debug.Log("POSITIVO" + screenBouns.x);
        Debug.Log("NEGATIVO" + -screenBouns.x);
    }

    public void DirectionPlayer()
    {
        float direction = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(direction * maxSpeed, body.velocity.y);

        if(direction > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if(direction < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    public void JumpPlayer()
    {
        isFloor = Physics2D.OverlapCircle(pie.position, radio, floor);
        if (isFloor)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                body.AddForce(new Vector2(0f, maxJump * 20));
            }
        }
    }

    public void ScreenPosition()
    {
        screenBouns = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        if(transform.position.x > screenBouns.x * 1.5)
        {
           transform.position = new Vector3(-screenBouns.x * 1.1f, transform.position.y, transform.position.z);
           
        }
        if(transform.position.x < -screenBouns.x *1.5)
        {
           transform.position = new Vector3(screenBouns.x * 1.1f, transform.position.y, transform.position.z);
        }

        //float posX = transform.position.x;
        //if(posX >= 8)
        //{
        //    transform.position = new Vector3(-8, -3, 0);
        //}
        //if(posX <= -8)
        //{
        //    transform.position = new Vector3(8, -3, 0);
        //}
    }

   

    


}
